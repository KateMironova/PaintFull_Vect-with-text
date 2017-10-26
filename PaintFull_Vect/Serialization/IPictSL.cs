using PaintFull_Vect.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintFull_Vect.Serialization
{
    public interface IPictSL
    {
        List<PFigure> Load();
        void Save(List<PFigure> figures);
    }
}
