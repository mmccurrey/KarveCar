﻿using KarveCar.Model.Generic;
using KarveCommon.Generic;
using static KarveCommon.Generic.RecopilatorioEnumerations;

namespace KarveCar.Model.Classes
{
    public class TipoProveedor : GenericPropertyChanged, IDataGridRowChange
    {
        #region Constructores
        public TipoProveedor() { this.ControlCambioDataGrid = EControlCambioDataGrid.Null; }
        public TipoProveedor(short codigo, string definicion, string ultimamodificacion, string usuario)
        {
            this.codigo = codigo;
            this.definicion = definicion;
            this.ultimamodificacion = ultimamodificacion;
            this.usuario = usuario;
        }
        #endregion

        #region Propiedades
        private short codigo;
        public short Codigo
        {
            get { return codigo; }
            set
            {
                codigo = value;
                OnPropertyChanged("Codigo");
            }
        }

        private string definicion;
        public string Definicion
        {
            get { return definicion; }
            set
            {
                definicion = value;
                OnPropertyChanged("Definicion");
            }
        }

        private string ultimamodificacion;
        public string UltimaModificacion
        {
            get { return ultimamodificacion; }
            set
            {
                ultimamodificacion = value;
                OnPropertyChanged("UltimaModificacion");
            }
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                OnPropertyChanged("Usuario");
            }
        }

        private EControlCambioDataGrid controlcambiodatagrid;
        public EControlCambioDataGrid ControlCambioDataGrid
        {
            get { return controlcambiodatagrid; }
            set
            {
                controlcambiodatagrid = value;
                OnPropertyChanged("ControlCambioDataGrid");
            }
        }
        #endregion
    }
}