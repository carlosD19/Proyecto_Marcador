﻿using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorBOL
{
    public class HistorialBOL
    {
        private HistorialDAL dal;
        public HistorialBOL()
        {
            dal = new HistorialDAL();
        }
        /// <summary>
        /// Carga los historiales
        /// </summary>
        /// <returns>lista de historiales</returns>
        public List<Historial> CargarTodo()
        {
            return dal.CargarTodo();
        }
    }
}
