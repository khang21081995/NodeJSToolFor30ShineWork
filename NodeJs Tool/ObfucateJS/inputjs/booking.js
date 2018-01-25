(function (factory) {
    // Browser globals
    factory(jQuery);
}
    (function ($) {
        var Booking = {
            $el: null,

            step: 0,
            phone: "",
            customerid: "",
            customerName: "",
            dateBook: "",
            staffId: 0,
            salonId: 0,
            bookingid: "",

            domains: {
                "apiBookingV2": window.apis.domains.apiBookingV2,
            },

            uris: {
                "getCustomerInfo": "/api/booking/customer-info",
                "addCustomer": "/api/booking/add-customer",
                "getBookingStylists": "/api/booking/stylists",
                "getBookingHours": "/api/booking/hours",
                "apiBooking": "/api/booking",
                "getBookingSalons": "/api/booking/salons",
            },

            authentications: {
                "applicationid": "d58939b1-9776-4947-ad7f-805416b0e6d1",
                "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIwOTE0Mzc2NzY2IiwianRpIjoiNmQyZTk2YWQtZmMzOS00NGQ3LWE3OGYtNjE3MWFiNWY2ZWUzIiwiaWF0IjoxNTA5NTEyMzk0LCJuYmYiOjE1MDk1MTIzOTQsImV4cCI6MTUwOTUxMjY5NCwiaXNzIjoiUEVYQ09NIiwiYXVkIjoiUEVYQ09NQXVkaWVuY2UifQ.-ho4wCtj0TPOoENVE5pDL2LE9eQZ9x9Bgro9OPDS6WE",
            },

            options: {
                clickInputPhone: function (success, error) { success(); },
                clickBtn3: function (success, error) { success(); },
                clickBtnSalon: function (success, error) { success(); },
                clickBtnDate: function (success, error) { success(); },
                clickBtnStylist: function (success, error) { success(); },
                clickBook: function (success, error) { success(); },
                clickCancelBook: function (success, error) { success(); },
                clickYesCancelIndexBook: function (success, error) { success(); },
                //clickStylistDefault: function (success, error) { success(); },
                clickYesUpdateBook: function (success, error) { success(); },
                clickNoUpdateBook: function (success, error) { success(); },
                clickYesCancelBook: function (success, error) { success(); },
                clickNoCancelBook: function (success, error) { success(); },
                clickClosePopup: function (success, error) { success(); },
            },

            events: {
                'click .booking-page .btn_n3': 'clickBtn3',
                'click .booking-page .btn-a-salon': 'clickBtnSalon',
                'click .booking-page .btn-date': 'clickBtnDate',
                'click .booking-page .btn-stylist': 'clickBtnStylist',
                'click .booking-page .btn-book': 'clickBook',
                'click .booking-page .btn-input-phone': 'clickInputPhone',
                //'click .booking-page .stylist-default': 'clickStylistDefault',
                'click .booking-page .btn-cancel-book': 'clickCancelBook',

                'click .booking-page .popup-confirm.update-book .button.yes': 'clickYesUpdateBook',
                'click .booking-page .popup-confirm.update-book .button.no': 'clickNoUpdateBook',
                'click .booking-page .popup-confirm.cancel-book.booking-success .button.yes': 'clickYesCancelBook',
                'click .booking-page .popup-confirm.cancel-book.index .button.yes': 'clickYesCancelIndexBook',
                'click .booking-page .popup-confirm.cancel-book .button.no': 'clickNoCancelBook',
                'click .booking-page .popup-confirm .close-popup': 'clickClosePopup'
            },
            elms: {
                //input phone
                'inputPhone': '.booking-page .step1 .input-phone',

                //wrap steps
                'wrapChooseSalon': '.booking-page .choose_salon',
                'wrapChooseStep3': '.booking-page .step3',
                'wrapBookingSuccess': '.booking-page .wrap.booking-success',
                'wrapBookingStep': '.booking-page .wrap.booking-step',
                'steps': '.booking-page .step_info',
                'step3': '.booking-page .step .step_info.step3',
                'step2': '.booking-page .step .step_info.step2',

                //btn step 2
                'hourListing': '.booking-page .time_detail.hour-listing',
                'viewSalonActive': '.booking-page .view_salon.active',
                'noticeSalonName': '.booking-page .notice .salon-name',
                'noticeSalonHotline': '.booking-page .notice .txtsdt',
                'stylistListing': '.booking-page .stylist-listing',
                'btnStylist': '.booking-page .btn-stylist',
                'stylistDefault': '.booking-page .stylist-default',
                'stylistActive': '.booking-page .btn-stylist.active',
                'stylistBtnList': '.booking-page .btn-stylist',
                'btnHourActive': '.booking-page .btn-hour.active',
                'dateActive': '.booking-page .date_info.active',
                'note': '.booking-page .note',
                'hourBook': '.booking-page .hour-book',

                //customer-info
                'customerName': '.booking-page .customer-info.customer-name',
                'customerPhone': '.booking-page .customer-info.customer-phone',
                'customerid': '.booking-page .customer-info.customer-id',
                'salonName': '.booking-page .customer-info.salon-name',
                'salonAddress': '.booking-page .customer-info.salon-address',
                'stylistName': '.booking-page .customer-info.stylist-name',
                'dateBook': '.booking-page .customer-info.date-book',

                //page load
                'pageLoading': '.page-loading',

                //booking success, step 3
                'bookingSuccessSalonName': '.booking-page .booking-success .salon-name',
                'bookingSuccessStylistName': '.booking-page .booking-success .stylist-name',
                'bookingSuccessDateTimeBook': '.booking-page .booking-success .date-book',
                'bookingSuccessDescription': '.booking-page .booking-success .description',
                'bookingSuccessCustomerName': '.booking-page .booking-success .customer-name',

                //popup
                'popupRemark': '.booking-page .popup-remark',
                'btnCancelBook': '.btn-cancel-book',
                'btnUpdateBook': '.btn-update-book',
                'popupCancelBook': '.popup-confirm.cancel-book',
                'closePopupCancelBook': '.btn-cancel-book .close-button',
                'popupUpdateBook': '.popup-confirm.update-book',
                'closePopupUpdateBook': '.popup-confirm.update-book .close-button',
                'closePopup': '.booking-page .popup-confirm .close-popup',
            },

            //=====Common function

            init: function (options, el) {
                let self = this;
                this.$el = $(el);
                this.undelegateEvents();
                this.delegateEvents();
                // Detect mobile devices
                (function (a) { (jQuery.browser = jQuery.browser || {}).mobile = /(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4)) })(navigator.userAgent || navigator.vendor || window.opera);
                if ($.browser.mobile) this.$el.addClass('mobile');
                $.extend(this.options, options);

                //set global params
                self.phone = self.getElementVal("customerPhone").text().trim();
                self.customerName = self.getElementVal("customerName").text().trim();
                self.customerid = self.getElementVal("customerid").text().trim();
                self.dateBook = self.getElementVal("dateBook").text().trim();
                console.log(self.phone + "|" + self.customerName + "|" + self.customerid + "|" + self.dateBook);
            },

            delegateEvents: function () {
                this.bindEvents(false);
            },

            undelegateEvents: function () {
                this.bindEvents(true);
            },

            getArrVal: function (items, atrrVal) {
                let arr = [];
                $.each(items, function (i, v) {
                    let dataValue = $(v).attr(atrrVal);
                    arr.push(dataValue);
                });
                return arr;
            },

            bindEvents: function (unbind) {
                var bindFunction = unbind ? 'off' : 'on';
                for (var key in this.events) {
                    var eventName = key.split(' ')[0];
                    var selector = key.split(' ').slice(1).join(' ');
                    var methodNames = this.events[key].split(' ');

                    for (var index in methodNames) {
                        if (methodNames.hasOwnProperty(index)) {
                            var method = this[methodNames[index]];

                            // Keep the context
                            method = $.proxy(method, this);

                            if (selector === '') {
                                this.$el[bindFunction](eventName, method);
                            } else {
                                this.$el[bindFunction](eventName, selector, method);
                            }
                        }
                    }
                }
            },

            getElementVal: function (key) {
                return target = $(this.elms[key]);
            },

            //=========================== end common function ===================================


            clickInputPhone: function (ev) {
                let self = this;
                let inputPhone = self.getElementVal('inputPhone');
                let phone = inputPhone.val();

                var success = function () {
                    //check valid phone
                    if (window.isPhone(phone)) {
                        window.location.href = '/booking?phone=' + phone;
                    } else {
                        window.showToast("msg", "Anh hãy nhập đúng số điện thoại!");
                    }
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickInputPhone(success, error);
            },

            clickBtnSalon: function (ev) {
                let self = this;
                let target = ev.target;
                let noticeSalonName = self.getElementVal("noticeSalonName");
                let noticeSalonHotline = self.getElementVal("noticeSalonHotline");

                var success = function () {
                    console.log("load step 3");
                    let salon = self.subFnGetSalonSelected();
                    let salonName = " (" + salon["name"] + ") ";
                    $(noticeSalonName).text(salonName);
                    $(noticeSalonHotline).text(salon["hotline"]);

                    //bind date defaut options stylist and salon
                    let salonid = self.subFnGetSalonSelected()["id"];
                    let workDate = self.subFnGetDateFomated(self.subFnGetDateActive());

                    let params = {
                        salonid: salonid,
                        workDate: workDate
                    }
                    //get then bind stylist, then by hour frame
                    self.subFnGetStylistBySalon(ev, params);
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickBtnSalon(success, error);
            },

            clickBtn3: function (ev) {
                let self = this;
                let wrapChooseSalon = self.getElementVal("wrapChooseSalon");
                let wrapChooseStep3 = self.getElementVal("wrapChooseStep3");
                let steps = self.getElementVal("steps");
                let step3 = self.getElementVal("step3");

                var success = function () {
                    console.log("click button next step 3");

                    let salonid = self.subFnGetSalonSelected()["id"];
                    if (!salonid) {
                        window.showToast("msg", "Xin hãy chọn salon!");
                        wrapChooseSalon.show();
                        wrapChooseStep3.hide();
                        return;
                    }
                    wrapChooseSalon.hide();
                    wrapChooseStep3.show();
                    steps.removeClass("active");
                    step3.addClass("active");
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickBtn3(success, error);
            },

            clickConfirmUpdate: function (ev) {
                var success = function () {
                    self.subFnPostBooking(data);
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickConfirmUpdate(success, error);
            },

            clickBook: function (ev) {
                let self = this;

                let hourid = self.subFnGetHourSelected()["id"];
                let salonid = self.subFnGetSalonSelected()["id"];
                let staffid = self.subFnGetStylistSelected()["id"];
                let note = $(self.getElementVal("note")).val();
                let workDate = self.subFnGetDateFomated(self.subFnGetDateActive());
                if (!hourid) {
                    window.showToast("msg", "Xin hãy chọn giờ đặt!");
                    return;
                }

                window.startLoading();

                if (!staffid) {
                    staffid = 0;
                }

                let data = {
                    "phone": self.phone,
                    "name": "",
                    "hourId": hourid,
                    "bookDate": workDate,
                    "salonId": salonid,
                    "staffId": staffid,
                    "maxSlotAll": 10,
                    "maxSlotCusNew": 10,
                    "maxSlotCusOld": 10,
                    "textNote": note
                }

                //console.log(data);
                var success = function () {
                    self.subFnPostBooking(data);
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickBook(success, error);
            },

            clickCancelBook: function (ev) {
                let self = this;
                let popupCancelBook = self.getElementVal("popupCancelBook");
                var success = function () {
                    popupCancelBook.removeClass("hide");
                    window.scrollTo(0, 0);
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickCancelBook(success, error);
            },

            //popup
            clickYesUpdateBook: function (ev) {
                let self = this;
                let popupUpdateBook = self.getElementVal("popupUpdateBook");
                let id = popupUpdateBook.attr("id");
                console.log("update popup id: " + id);
                var success = function () {
                    popupUpdateBook.addClass("hide");
                    self.subConfirmUpdateBook(id);
                    window.scrollTo(0, 0);
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickYesUpdateBook(success, error);
            },

            clickNoUpdateBook: function (ev) {
                let self = this;
                let popupUpdateBook = self.getElementVal("popupUpdateBook");
                var success = function () {
                    popupUpdateBook.addClass("hide");
                    return true;
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickNoUpdateBook(success, error);
            },

            clickYesCancelBook: function (ev) {
                let self = this;
                let popupCancelBook = self.getElementVal("popupCancelBook");
                var success = function () {
                    popupCancelBook.addClass("hide");
                    //let dateBook = self.subFnGetDateFomated(self.subFnGetDateActive());
                    let dateBook = self.dateBook;
                    let params = {
                        phone: self.phone,
                        bookDate: dateBook
                    };
                    let success = self.subFnCancelBooking(params);
                    self.subFnSetPageAfterCancelBooking(success, "booking-success");
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickYesCancelBook(success, error);
            },

            clickYesCancelIndexBook: function (ev) {
                let self = this;
                let popupCancelBook = self.getElementVal("popupCancelBook");
                var success = function () {
                    popupCancelBook.addClass("hide");
                    let dateBook = self.dateBook;
                    let params = {
                        phone: self.phone,
                        bookDate: dateBook
                    };
                    let success = self.subFnCancelBooking(params);
                    self.subFnSetPageAfterCancelBooking(success, "index");
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickYesCancelIndexBook(success, error);
            },

            clickNoCancelBook: function (ev) {
                let self = this;
                let popupCancelBook = self.getElementVal("popupCancelBook");
                var success = function () {
                    popupCancelBook.addClass("hide");
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickNoCancelBook(success, error);
            },

            clickClosePopup: function (ev) {
                let self = this;
                let closePopup = self.getElementVal("closePopup");
                var success = function () {
                    closePopup.parents(".popup-confirm").addClass("hide");
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickNoCancelBook(success, error);
            },

            //popup
            clickBtnStylist: function (ev, makeLoad) {
                console.log("click stylist");
                let self = this;
                //let btnStylist = self.getElementVal("btnStylist");
                let target = ev.target;
                let isDefault = $(target).hasClass("stylist-default");
                let staffid = $(target).attr("id");
                let salonid = self.subFnGetSalonSelected()["id"];
                let workDate = self.subFnGetDateFomated(self.subFnGetDateActive());
                let params = {};
                if (!isDefault && makeLoad !== false) {
                    window.startLoading();
                    params = {
                        salonid: salonid,
                        staffid: ~~staffid,
                        workDate: workDate
                    };
                } else {
                    params = {
                        salonid: salonid,
                        staffid: 0,
                        workDate: workDate
                    };
                }
                var success = function () {
                    //get then bind hour
                    self.subFnGetHourFrame(params);
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickBtnStylist(success, error);
            },


            clickBtnDate: function (ev) {
                console.log("click choose date");
                window.startLoading();
                let self = this;
                let salonid = self.subFnGetSalonSelected()["id"];
                let staffid = self.subFnGetStylistSelected()["id"];
                let workDate = self.subFnGetDateFomated(self.subFnGetDateActive());

                if (!salonid) {
                    window.showToast("msg", "Xin hãy chọn Salon");
                }

                let params = {
                    salonid: salonid,
                    staffid: staffid,
                    workDate: workDate
                }

                var success = function () {
                    self.subFnGetHourFrame(params);
                };
                var error = function () {
                    console.log("error");
                };
                this.options.clickBtnDate(success, error);
            },

            //======== sub function of main function

            subFnGetStylistBySalon: function (ev, params) {
                let self = this;
                let salonid = params["salonid"];
                let workDate = params["workDate"];
                let stylistListing = self.getElementVal("stylistListing");
                let url = '/booking/stylist?salonId=' + salonid + "&workDate=" + workDate;
                $("#stylist-listing").submit();
                $("#stylist-listing").load(url, function () {
                    //let staffid = self.subFnGetStylistSelected()["id"];
                    //params["staffid"] = staffid;
                    ////get then bind hour
                    //self.subFnGetHourFrame(params);
                    let stylistDefault = self.getElementVal("stylistDefault");
                    let btnStylist = self.getElementVal("btnStylist");
                    btnStylist.removeClass("active");
                    btnStylist.find("img").removeClass("active");
                    stylistDefault.addClass("active");
                    stylistDefault.find("img").addClass("active");
                    let makeLoad = false;
                    self.clickBtnStylist(ev, makeLoad);
                });
            },

            subFnGetHourFrame: function (params) {
                console.log(params);
                let self = this;
                let domain = self.domains["apiBookingV2"];
                let uri = self.uris["getBookingHours"];
                let url = domain + uri;

                let salonid = params["salonid"];
                let workDate = params["workDate"];
                let staffid = params["staffid"];

                //if default stylist then stylist=0
                let data = {
                    "staffId": staffid,
                    "salonId": salonid,
                    "workDate": workDate,
                    "phone": self.phone,
                    "name": ""
                };

                $.ajax({
                    url: url + "?" + $.param(data),
                    type: "GET",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    async: false,
                    //headers: headers,
                    data: JSON.stringify(data),
                    success: function (response) {
                        self.subFnBindHourFrame(response);
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        self.errorCallback("booking " + jqXHR + "|" + textStatus + "|" + errorThrown);
                    }
                });
            },


            subFnPostBooking(data) {
                console.log(data);
                let self = this;
                let domain = self.domains["apiBookingV2"];
                let uri = self.uris["apiBooking"];
                let url = domain + uri;
                $.ajax({
                    url: url,
                    type: "POST",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    async: false,
                    //headers: headers,
                    data: JSON.stringify(data),
                    success: function (response) {
                        console.log(response);

                        window.showToast("msg", response.message);

                        if (!response.isConfirm) {

                            self.subFnBindBookingSuccess();
                        } else {
                            console.log("confirm update book");
                            let order = response.order;
                            let id = order.bookingId;
                            let popupUpdateBook = self.getElementVal("popupUpdateBook");
                            popupUpdateBook.removeClass("hide");
                            popupUpdateBook.attr("id", id);
                        }
                        window.finishLoading();
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        if (jqXHR === 403) {
                            self.subFnBindBookingSuccess();
                            window.finishLoading();
                        } else {
                            self.errorCallback("booking " + jqXHR + "|" + textStatus + "|" + errorThrown);
                        }
                    }
                });
            },

            subFnPutBooking(id, data) {
                console.log(data);
                let self = this;
                let domain = self.domains["apiBookingV2"];
                let uri = self.uris["apiBooking"];
                let url = domain + uri;
                $.ajax({
                    url: url + "?id=" + id,
                    type: "PUT",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    async: false,
                    //headers: headers,
                    data: JSON.stringify(data),
                    success: function (response) {
                        console.log(response);
                        self.subFnBindBookingSuccess();
                        window.showToast("msg", response.message);
                        window.finishLoading();
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        self.errorCallback("booking " + jqXHR + "|" + textStatus + "|" + errorThrown);
                    }
                });
            },

            subFnBindBookingSuccess: function (ev) {
                let self = this;
                //let wrapBookingSuccess = self.getElementVal("wrapBookingSuccess");
                //let wrapBookingStep = self.getElementVal("wrapBookingStep");
                //let bookingSuccessSalonName = self.getElementVal("bookingSuccessSalonName");
                //let bookingSuccessStylistName = self.getElementVal("bookingSuccessStylistName");
                //let bookingSuccessDateTimeBook = self.getElementVal("bookingSuccessDateTimeBook");
                //let bookingSuccessDescription = self.getElementVal("bookingSuccessDescription");
                //let bookingSuccessCustomerName = self.getElementVal("bookingSuccessCustomerName");

                let dateBook = self.subFnGetDateFomated(self.subFnGetDateActive());
                let hourBook = self.subFnGetHourSelected()["value"];
                let salonName = self.subFnGetSalonSelected()["name"];
                let stylistName = self.subFnGetStylistSelected()["name"];
                //let customerPhone = self.phone;

                let description = self.subFnGetDescription(dateBook + " " + hourBook);
                //window.showToast("msg", description);
                //let data = hourBook + " ngày " + dateBook + "|" + salonName + "|" + stylistName + "|" + description;

                window.location.href = "/booking/success?hourBook=" + hourBook + "&dateBook=" + dateBook + "&salonName=" + salonName + "&stylistName=" + stylistName + "&description=" + description;

                //wrapBookingSuccess.removeClass("hide");
                //wrapBookingStep.addClass("hide");
                //bookingSuccessSalonName.text(salonName);
                //bookingSuccessStylistName.text(stylistName);
                //bookingSuccessDateTimeBook.text(hourBook + " ngày " + dateBook);
                //bookingSuccessDescription.text(description);
                //bookingSuccessCustomerName.text(self.customerName);
            },

            subConfirmUpdateBook: function (id) {
                let self = this;
                let hourid = self.subFnGetHourSelected()["id"];
                let salonid = self.subFnGetSalonSelected()["id"];
                let staffid = self.subFnGetStylistSelected()["id"];
                let note = $(self.getElementVal("note")).val();
                let currentDate = new Date();
                let workDate = self.subFnGetDateFomated(self.subFnGetDateActive());
                //let startDate = self.subFnGetDateFomated(currentDate);

                if (!hourid) {
                    window.showToast("msg", "Xin hãy chọn giờ đặt");
                    window.finishLoading();
                    return;
                }

                if (!staffid) {
                    staffid = 0;
                }

                let data = {
                    "phone": self.phone,
                    "name": "",
                    "hourId": hourid,
                    "bookDate": workDate,
                    "salonId": salonid,
                    "staffId": staffid,
                    "maxSlotAll": 10,
                    "maxSlotCusNew": 10,
                    "maxSlotCusOld": 10,
                    "textNote": note
                };

                self.subFnPutBooking(id, data);
            },


            subFnCancelBooking(params) {
                console.log(params);
                let self = this;
                let domain = self.domains["apiBookingV2"];
                let uri = self.uris["apiBooking"];
                let url = domain + uri;
                let success = false;
                $.ajax({
                    url: url + "?" + $.param(params),
                    type: "DELETE",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    async: false,
                    //data: JSON.stringify(params),
                    success: function (response) {
                        console.log(response);
                        success = true;
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        self.errorCallback("booking " + jqXHR + "|" + textStatus + "|" + errorThrown);
                    }
                });
                return success;
            },

            subFnSetPageAfterCancelBooking(success, page) {
                let self = this;
                if (page === "index") {
                    if (success) {
                        window.showToast("msg", "Hủy lịch thành công");
                        window.location.href = "/";
                    } else {
                        window.showToast("err", "Đã có lỗi!");
                    }
                } else if (page === "booking-success") {
                    let wrapBookingSuccess = self.getElementVal("wrapBookingSuccess");
                    let wrapBookingStep = self.getElementVal("wrapBookingStep");
                    let steps = self.getElementVal("steps");
                    let step2 = self.getElementVal("step2");
                    if (success) {
                        window.showToast("msg", "Hủy lịch thành công");
                        wrapBookingSuccess.addClass("hide");
                        wrapBookingStep.removeClass("hide");
                        steps.removeClass("active");
                        step2.addClass("active");
                    } else {
                        wrapBookingSuccess.removeClass("hide");
                        wrapBookingStep.addClass("hide");
                    }
                }
                window.location.href = "/";
            },

            subFnBindHourFrame: function (data) {
                console.log("bind hour frame");
                //console.log(data);
                let self = this;
                let hourListing = self.getElementVal("hourListing");
                let items = "";
                //data.shift();
                $.each(data, function (i, v) {
                    let status = v.status;
                    let hour = v.hour.replace("h", ":");
                    let id = v.id;
                    let item = "";
                    let on = "Còn chỗ";
                    let fill = "Hết chỗ";
                    //let off = "Nghỉ";
                    switch (status) {
                        case 0:
                            item = '<div id="' + id + '" class="btn-hour col-lg-3 col-sm-3 col-md-3 col-xs-3 fix_col">' +
                                '<div id="' + id + '" onclick= "choose_time($(this))" class="btn-hour fill time_table border-red">' +
                                '<p class="text hour">' + hour + '</p><p class="text status" >' + fill + '</p></div></div>';
                            break;
                        case 1:
                            item = '<div id="' + id + '" class="btn-hour col-lg-3 col-sm-3 col-md-3 col-xs-3 fix_col">' +
                                '<div id="' + id + '" onclick= "choose_time($(this))" class="btn-hour on time_table border-green">' +
                                '<p class="text hour">' + hour + '</p><p class="text status">' + on + '</p></div></div>';
                            break;
                    }
                    items += item;
                });
                $(hourListing).empty().append(items);
                window.finishLoading();
            },

            subFnGetDescription(dateTimeBook) {
                console.log(dateTimeBook);
                let self = this;
                let description = "";

                let dates = dateTimeBook.split(" ")[0].split("/");
                let time = dateTimeBook.split(" ")[1].split(":");
                let bookDay = dates[0];
                let bookMonth = dates[1];
                let bookHour = time[0];
                let bookMin = time[1];

                let now = new Date();
                let today = now.getDate();
                let thisMonth = (("0" + (now.getMonth() + 1)).slice(-2));
                let thisHours = now.getHours();
                let thisMin = now.getMinutes();


                if (thisMonth === bookMonth) {
                    description = "Còn ";
                    let diffDay = parseInt(bookDay) - parseInt(today);
                    if (diffDay > 0) {
                        description += diffDay + ' ngày ';
                    }

                    let diffHour = parseInt(bookHour) - parseInt(thisHours);
                    if (diffHour < 0) {
                        diffHour = diffHour * (-1);
                    }
                    if (diffHour > 0) {
                        description += diffHour + ' giờ ';
                    }

                    let diffMin = parseInt(bookMin) - parseInt(thisMin);
                    if (diffMin < 0) {
                        diffMin = diffMin * (-1);
                    }
                    if (diffMin > 0) {
                        description += diffMin + ' phút ';
                    }

                    description += ' là tới giờ cắt tóc của anh!';
                }
                return description;
            },

            subFnGetSalonSelected() {
                let self = this;
                let viewSalonActive = self.getElementVal("viewSalonActive");
                let id = viewSalonActive.attr("id");
                let name = viewSalonActive.find(".text").text();
                let hotline = viewSalonActive.find(".hotline").text();
                let salon = {
                    name: name,
                    hotline: hotline,
                    id: ~~id
                };
                return salon;
            },

            subFnGetStylistSelected() {
                console.log("stylist selected");
                let self = this;
                let stylistActive = self.getElementVal("stylistActive");
                let id = $(stylistActive).attr("id");
                let name = $(stylistActive).find(".name").text();

                let stylist = {
                    id: ~~id,
                    name: name
                }
                console.log(stylist);
                return stylist;
            },

            subFnGetStylistidFirst() {
                let self = this;
                let stylistBtnList = self.getElementVal("stylistBtnList");
                let firstid = $(stylistBtnList[1]).attr("id");
                return ~~firstid;
            },

            subFnGetHourSelected() {
                let self = this;
                let btnHourActive = self.getElementVal("btnHourActive");
                let id = $(btnHourActive).attr("id");
                let value = $(btnHourActive.find(".hour")).text();

                let hour = {
                    id: ~~id,
                    value: value
                }
                return hour;
            },

            subFnGetDateActive() {
                let self = this;
                let dateActive = self.getElementVal("dateActive");
                //if today
                let date = new Date();
                if ($(dateActive).hasClass("tomorrow")) {
                    date.setDate(date.getDate() + 1);
                } else if ($(dateActive).hasClass("after-tomorrow")) {
                    date.setDate(date.getDate() + 2);
                }
                return date;
            },

            subFnGetDateFomated(date, format) {
                let workDate = "";

                if (format === "yyyy_MM_dd") {
                    return workDate = date.getFullYear() + "_" + ("0" + (date.getMonth() + 1)).slice(-2) + "_" + date.getDate();
                }
                else if (format === "yyyy-MM-dd") {
                    return workDate = date.getFullYear() + "-" + ("0" + (date.getMonth() + 1)).slice(-2) + "-" + date.getDate();
                }
                else {
                    //default
                    workDate = date.getDate() + "/" + ("0" + (date.getMonth() + 1)).slice(-2) + "/" + date.getFullYear();
                }
                //return workDate = date.getDate() + "/" + date.getMonth() + "/" + date.getFullYear();
                return workDate;
            },

            //error
            errorCallback: function (err) {
                window.showToast("err", "err");
                window.finishLoading();
            },

        }

        // final init object 
        $.fn.booking = function (options) {
            return this.each(function () {
                var booking = Object.create(Booking);
                booking.init(options || {}, this);
                $.data(this, 'booking', booking);
            });
        };
    }));