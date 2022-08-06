$(function () {

    var l = abp.localization.getResource('VendaCap');

    var service = vendaCap.common.ticketSet;
    var createModal = new abp.ModalManager(abp.appPath + 'Common/TicketSet/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Common/TicketSet/EditModal');

    var dataTable = $('#TicketSetTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('VendaCap.TicketSet.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('VendaCap.TicketSet.Delete'),
                                confirmMessage: function (data) {
                                    return l('TicketSetDeletionConfirmationMessage', data.record.id);
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
                title: l('TicketSetDrawDate'),
                data: "drawDate"
            },
            {
                title: l('TicketSetAmount'),
                data: "amount"
            },
            {
                title: l('TicketSetPrice'),
                data: "price"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewTicketSetButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
