$(function () {
    todo.server.getAllItems(function (items) {
        var listViewModel = todo.createTodoListViewModel(items);
        
        ko.applyBindings(listViewModel);
    });
})