$(function () {

    var l = abp.localization.getResource('VendaCap');

    var service = vendaCap.common.place;
    var createModal = new abp.ModalManager(abp.appPath + 'Common/Place/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Common/Place/EditModal');

    var dataTable = $('#PlaceTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('VendaCap.Place.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('VendaCap.Place.Delete'),
                                confirmMessage: function (data) {
                                    return l('PlaceDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('PlaceName'),
                data: "name"
            },
            {
                title: l('PlaceAbbrev'),
                data: "abbrev"
            },
            {
                title: l('PlaceIbgeCode'),
                data: "ibgeCode"
            },
            {
                title: l('PlaceBacenCode'),
                data: "bacenCode"
            },
            {
                title: l('PlacePlaceParent'),
                data: "placeParent"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewPlaceButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
