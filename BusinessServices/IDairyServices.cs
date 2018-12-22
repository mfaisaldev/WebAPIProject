using System.Collections.Generic;
using BusinessEntities;

namespace BusinessServices
{
    /// <summary>
    /// Dairy Service Contract
    /// </summary>
    public interface IDairyServices
    {
        DairyEntity GetDairyById(int dairyId);
        IEnumerable<DairyEntity> GetAllDairys();
        double CreateDairy(DairyEntity dairyEntity);
        bool UpdateDairy(int dairyId, DairyEntity dairyEntity);
        bool DeleteDairy(int dairyId);
    }
}
