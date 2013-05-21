var todo = todo || {};

todo.createTodoListViewModel = function (items) {
    
    var itemViewModels = items.map(function (item) {
        return todo.createItemViewModel(item);
    });
    
    var viewModel = {
        title: "Knockout.js TODO list",
        items: ko.observableArray(itemViewModels),
    };

    viewModel.removeItem = function (item) {
        todo.server.remove(item.id, function() {
            viewModel.items.remove(item);
        });
    };

    viewModel.addItemFromForm = function(form) {
        var descriptionInput = form["description"];
        
        var newDescription = descriptionInput.value;
        
        todo.server.add(newDescription, function (item) {
            viewModel.items.push(todo.createItemViewModel(item));
            descriptionInput.value = null;
        });
    };

    return viewModel;
}