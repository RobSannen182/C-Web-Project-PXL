using MVCHogeschoolPXL.Models;
using MVCHogeschoolPXL.ViewModels;
using System.Collections.Generic;

namespace MVCHogeschoolPXL.Data
{
    public interface IGebruikersRepo
    {
        List<GebruikerInfo> GetGebruikersInfoList(string functie = null);
        Lector GetLectorById(int id);
        List<LectorNaamId> GetLectorNaamIdList();
        List<LectorNaamId> GetLectorNaamIdListByVak(int vakId);
        List<StudentNaamId> GetStudentNaamIdList();
        VakLector GetVaklectorById(int id);
        List<VakLectorNaam> GetVakLectorNaamListByVak(int vakId);
    }
}