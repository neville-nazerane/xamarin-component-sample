using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    public class MainViewModel
    {

        public Item Demo { get; set; }

        public MainViewModel()
        {
            Demo = new Item {
                Title = "This is the valid sample",
                Description = "This is a valid sample"
            };
        }

    }
}
