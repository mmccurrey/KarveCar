﻿using KarveCar.ViewModel.ConfiguracionViewModel;
using KarveCommon.Command;
using System;

namespace KarveCar.Commands.ConfiguracionCommand
{
    public class CintaOpcionesCommand : AbstractCommand
    {
        private CintaOpcionesViewModel cintaopcionesvm;

        public CintaOpcionesCommand() { }
        public CintaOpcionesCommand(CintaOpcionesViewModel vm)
        {
            this.cintaopcionesvm = vm;
        }

        public override void Execute(object parameter)
        {
            cintaopcionesvm.CintaOpciones(parameter);
        }

        public override bool UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
