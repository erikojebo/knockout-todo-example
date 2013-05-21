using System;
using System.Collections.Generic;
using System.Web.Http;
using KnockoutTodoExample.Models;
using WeenyMapper;

namespace KnockoutTodoExample.Controllers
{
    public class TodoController : ApiController
    {
        private readonly Repository _repository = new Repository();

        public IEnumerable<TodoItem> Get()
        {
            return _repository.Find<TodoItem>()
                              .OrderBy(x => x.AddedDate)
                              .ExecuteList();
        }

        public TodoItem Get(Guid id)
        {
            return _repository.Find<TodoItem>().Where(x => x.Id == id).Execute();
        }

        public TodoItem Post([FromBody] TodoItem item)
        {
            _repository.Insert(item);

            return item;
        }

        public void Put([FromBody] TodoItem item)
        {
            _repository.Update<TodoItem>()
                       .Set(x => x.IsDone, item.IsDone)
                       .Where(x => x.Id == item.Id)
                       .Execute();
        }

        public void Delete(Guid id)
        {
            _repository.Delete<TodoItem>().Where(x => x.Id == id).Execute();
        }
    }
}