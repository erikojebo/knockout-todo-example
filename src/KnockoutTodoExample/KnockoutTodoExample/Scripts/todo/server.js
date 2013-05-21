var todo = todo || {};

todo.server = (function () {
    var todoUrl = todo.url("api/todo");
    
    var getAllItems = function(success) {
        $.ajax({
            url: todoUrl,
            type: "GET"
        }).done(success);
    };

    var updateIsDone = function (id, isDone, success) {
        $.ajax({
            url: todoUrl,
            type: "PUT",
            data: { id: id, isDone: isDone }
        }).done(success);
    };

    var remove = function (id, success) {
        $.ajax({
            url: todoUrl + "/" + id,
            type: "DELETE"
        }).done(success);
    };

    var add = function (description, success) {
        $.ajax({
            url: todoUrl,
            type: "POST",
            data: { description: description }
        }).done(success);
    };
    
    return {
        getAllItems: getAllItems,
        updateIsDone: updateIsDone,
        remove: remove,
        add: add
    };
})();