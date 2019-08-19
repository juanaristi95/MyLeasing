using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLeasing.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        // creamos constructor para inyectarle el datacontext o BD
        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboLessees()
        {
            var list = _dataContext.Lessees.Include(l => l.User)
                .Select(p => new SelectListItem
            {
                Text = p.User.FullNameWithDocument,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a lessee...)",
                Value = "0"
            });

            return list;
        }


        public IEnumerable<SelectListItem> GetComboPropertyTypes()
        {
            // aqui convertimos cada propertytype a un nuevo item de
            // la lista del combo box.
            var list = _dataContext.PropertyTypes.Select(p => new SelectListItem
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
