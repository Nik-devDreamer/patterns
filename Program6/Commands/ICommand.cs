﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6.Commands
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
