using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class MyCommand : ICommand
    {
        private ICommand _next;
        private string _name;

        public MyCommand(ICommand next, string name)
        {
            _next = next;
            _name = name;
        }

        public async Task Execute()
        {
            Console.WriteLine(_name);
            if (_next != null)
            {
                await _next.Execute();
            }
        }


    }
}
