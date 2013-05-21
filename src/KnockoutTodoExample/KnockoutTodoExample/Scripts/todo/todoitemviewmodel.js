var todo = todo || {};

todo.createItemViewModel = function (item) {
    var viewModel = {
        id: item.id,
        description: item.description,
        isDone: ko.observable(item.isDone)
    };
    
    viewModel.toggleIsDone = function () {
        viewModel.updateIsDone(!viewModel.isDone());
    };

    viewModel.updateIsDone = function (isDone) {
        todo.server.updateIsDone(viewModel.id, isDone, function() {
            viewModel.isDone(isDone);
        });
    };

    return viewModel;
};