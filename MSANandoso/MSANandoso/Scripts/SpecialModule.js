var SpecialModule = (function () {
    return {
        getSpecials: function (callback) {
            showSpinner();
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://msa2015nandoso.azurewebsites.net/api/Specials",
                success: function (data) {
                    callback(data);
                    $('.spin').hide();
                }
            });
        }
    }
}());