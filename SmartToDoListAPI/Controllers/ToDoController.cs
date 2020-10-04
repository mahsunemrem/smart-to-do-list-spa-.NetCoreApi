using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartToDoListAPI.Business.Services.Abstract;
using SmartToDoListAPI.DataAccess.Abstract;
using SmartToDoListAPI.Entities.Dtos;
using SmartToDoListAPI.Entities.ViewModel;

namespace SmartToDoListAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoTitleService _toDoTitleService;
        private readonly IToDoTitleDal _toDoTitleDal;
        private readonly IToDoItemService _toDoItemService;
 
        public ToDoController(IToDoTitleService toDoTitleService, IToDoItemService toDoItemService,IToDoTitleDal toDoTitleDal)
        {
            _toDoTitleService = toDoTitleService;
            _toDoItemService = toDoItemService;
            _toDoTitleDal = toDoTitleDal;
        }
        [HttpGet]
        public IActionResult Index()
        {

            var list = new List<ToDoCardViewModel>();

            var titleList = _toDoTitleService.GetList().Data;
            var itemList = _toDoItemService.GetList().Data;

            foreach (var title in titleList)
            {
                var items =itemList.Where(c => c.ToDoTitleId == title.Id).ToList();

                list.Add(new ToDoCardViewModel() { ToDoItem = items, ToDoTitle = title });
            }

            return Ok(list);
        }

        [HttpPost("save-item")]
        public IActionResult SaveItem(ToDoItemDto model)
        {

            if (model.Id==Guid.Empty)
            {
                model.Id = Guid.NewGuid();
                _toDoItemService.Add(model);
            }

            else
            {
                _toDoItemService.Update(model);
            }

            return Ok();

        }

        [HttpPost("saveTitle")]
        public IActionResult SaveTitle(ToDoTitleDto model)
        {
            if (model.Id == Guid.Empty)
            {
                model.Id = Guid.NewGuid();
                _toDoTitleService.Add(model);
            }

            else
            {
                _toDoTitleService.Update(model);
            }

            return Ok();

        }


        [HttpGet("delete-title")]
        public IActionResult DeleteTitle(Guid id)
        {

            var list = _toDoItemService.GetList(c => c.ToDoTitleId == id).Data;

            list.ForEach(c => _toDoItemService.Delete(c));

            var a = _toDoTitleDal.Get(c => c.Id == id);

            var title = _toDoTitleService.Get(c => c.Id == id).Data;

            _toDoTitleService.Delete(title);

            
            
            return Ok();

        }

        [HttpGet("clear-item")]
        public IActionResult ClearItem(Guid id)
        {

            var list = _toDoItemService.GetList(c => c.ToDoTitleId == id).Data;

            list.ForEach(c => _toDoItemService.Delete(c));

            return Ok();

        }

        [HttpGet("isDone-item")]
        public IActionResult IsDoneItem(Guid id,bool isDone)
        {

            var item = _toDoItemService.Get(c => c.Id == id).Data;

            item.isDone = isDone;

            _toDoItemService.Update(item);

            return Ok();

        }

    }
}
