using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Interfaces
{
    public interface ISectionRepository : IDisposable
    {
        IEnumerable<Section> GetSectionList();
        Section GetSection(int id);
        void Create(Section section);
        void Update(Section section);
        void Delete(int id);
        void Save();
    }
}
