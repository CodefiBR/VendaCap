$(function () {

    var l = abp.localization.getResource('VendaCap');

    var service = vendaCap.common.person;
    var createModal = new abp.ModalManager(abp.appPath + 'Common/Person/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Common/Person/EditModal');

    var dataTable = $('#PersonTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('VendaCap.Person.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('VendaCap.Person.Delete'),
                                confirmMessage: function (data) {
                                    return l('PersonDeletionConfirmationMessage', data.record.id);
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
                title: l('PersonName'),
                data: "name"
            },
            {
                title: l('PersonDocument'),
                data: "document"
            },
            {
                title: l('PersonBirthDate'),
                data: "birthDate"
            },
            {
                title: l('PersonCellPhone'),
                data: "cellPhone"
            },
            {
                title: l('PersonPhone'),
                data: "phone"
            },
            {
                title: l('PersonEmail'),
                data: "email"
            },
            {
                title: l('PersonZipCode'),
                data: "zipCode"
            },
            {
                title: l('PersonAddress'),
                data: "address"
            },
            {
                title: l('PersonAddressNumber'),
                data: "addressNumber"
            },
            {
                title: l('PersonAddressComplement'),
                data: "addressComplement"
            },
            {
                title: l('PersonNeighborhood'),
                data: "neighborhood"
            },
            {
                title: l('PersonCityName'),
                data: "cityName"
            },
            {
                title: l('PersonStateName'),
                data: "stateName"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewPersonButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
