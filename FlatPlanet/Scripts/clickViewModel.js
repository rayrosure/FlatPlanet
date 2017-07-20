
$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);

var ClickCounterViewModel = function () {
    this.numberOfClicks = ko.observable(0);

    this.registerClick = function () {
        $.ajax({
            url: "/Home/Click",
            method: "POST",
            data: { numberOfClicks: this.numberOfClicks() + 1 }
        })
          .done(function (latestClickCount) {
              viewModel.numberOfClicks(latestClickCount);
          });
    };

    this.getLatestClickCount = function () {
        $.ajax({
            url: "/Home/GetLatestCount",
            method: "GET"
        })
        .done(function (latestClickCount) {
            viewModel.numberOfClicks(latestClickCount);
        });
    };

    this.hasClickedTooManyTimes = ko.pureComputed(function () {
        return this.numberOfClicks() >= 10;
    }, this);
};

var viewModel = new ClickCounterViewModel();

ko.applyBindings(viewModel);

viewModel.getLatestClickCount();