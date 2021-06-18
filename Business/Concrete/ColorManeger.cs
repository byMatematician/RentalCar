using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManeger : IColorService
    {
        IColorDal _colorDal;

        public ColorManeger(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Entities.Concrete.Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
