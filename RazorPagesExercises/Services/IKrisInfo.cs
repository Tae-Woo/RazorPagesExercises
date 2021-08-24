using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesExercises.Services
{
    public interface IKrisInfo
    {
        List<KrisInfo> GetAllKrisInformation();
        List<KrisInfo> GetEmergencies();
        KrisInfo GetKrisInformation(string id);
    }
}
