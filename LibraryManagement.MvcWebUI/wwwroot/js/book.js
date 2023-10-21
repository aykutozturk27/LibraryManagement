$(document).ready(function () {
    //var isBorrowed = $('#btnSetBookBorrowed').attr("data-isBorrowedValue");
    //var tableRow = $('#bookListTable tr');
    //if (isBorrowed === "True") {
    //    $(tableRow).find('td:last-child').attr('disabled', true);
    //}
    //else {
    //    $(tableRow).find('td:last-child').attr('disabled', false);
    //}

    getBookList();
})

function getBookList() {
    $('#bookListTable').DataTable({
        "processing": true,
        "serverSide": true,
        "ajax": {
            "url": "/Book/GetBookList",
            "contentType": "application/json",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "BookName" },
            { "data": "Author"},
            { "data": "ISBN" },
            { "data": "ReceivingDate" },
            { "data": "ReturnDate" },
        ]
    });
}

$('#btnSetBookBorrowed').click(function () {
    var identity = $(this).attr("data-identityValue");
    $.ajax({
        type: "POST",
        url: "/Book/SetBookBorrowed",
        data: { identityNumber: identity },
        dataType: "json",
        success: function () {
            iziToast.success({
                title: 'Kitabı Ödünç Al',
                message: 'Kitap başarılı bir şekilde ödünç alındı',
                position: 'center',
            });
        },
        error: function () {
            iziToast.error({
                title: 'Kitabı Ödünç Al',
                message: 'Kitap ödünç alma başarısız',
                position: 'center',
            });
        }
    })
})