using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_API_SampleProject.Models;

namespace MVVM_API_SampleProject.ViewModels
{
    public class ToDoViewModel
    {
        public ToDo ToDo { get; set; }

        public ToDoViewModel()

        {
            ToDo = new ToDo()
            {
                Id = 1,
                UserId = 1,
                Title = "Cortar a Grama",
                Completed = false
            };
        }

        }
}
