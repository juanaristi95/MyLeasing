using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLeasing.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _datContext;

        // creamos constructor para inyectarle el datacontext o BD
        public CombosHelper(DataContext datContext)
        {
            _datContext = datContext;
        }
        public IEnumerable<SelectListItem> GetComboPropertyTypes()
        {
            // aqui convertimos cada propertytype a un nuevo item de
            // la lista del combo box.
            var list = _datContext.PropertyTypes.Select(p => new SelectListItem
            {
                Text = p.Name,
                // 1ra forma sin interpolacion
                // Value = p.Id.ToString()
                // 2da forma con interpolacion - mas optima 
                Value = $"{p.Id}"
            }).OrderBy(p => p.Text).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "(Select a property Type...)",
                Value = "0"
            });
            return list;
        }
    }
}
