using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using AutoMapper;
using BusinessEntities;
using DataModel;
using DataModel.UnitOfWork;

namespace BusinessServices
{
    /// <summary>
    /// Offers services for dairy specific CRUD operations
    /// </summary>
    public class DairyServices : IDairyServices
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public DairyServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Fetches dairy details by id
        /// </summary>
        /// <param name="dairyId"></param>
        /// <returns></returns>
        public BusinessEntities.DairyEntity GetDairyById(int dairyId)
        {
            var dairy = _unitOfWork.DairyRepository.GetByID(dairyId);
            if (dairy != null)
            {
                Mapper.CreateMap<DOC_RECEIVING_HEADER, DairyEntity>();
                var dairyModel = Mapper.Map<DOC_RECEIVING_HEADER, DairyEntity>(dairy);
                return dairyModel;
            }
            return null;
        }

        /// <summary>
        /// Fetches all the dairys.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BusinessEntities.DairyEntity> GetAllDairys()
        {
            var dairys = _unitOfWork.DairyRepository.GetAll().ToList();
            if (dairys.Any())
            {
                Mapper.CreateMap<DOC_RECEIVING_HEADER, DairyEntity>();
                var dairysModel = Mapper.Map<List<DOC_RECEIVING_HEADER>, List<DairyEntity>>(dairys);
                return dairysModel;
            }
            return null;
        }

        /// <summary>
        /// Creates a dairy
        /// </summary>
        /// <param name="dairyEntity"></param>
        /// <returns></returns>
        public double CreateDairy(BusinessEntities.DairyEntity dairyEntity)
        {
            using (var scope = new TransactionScope())
            {
                var dairy = new DOC_RECEIVING_HEADER
                {
                    HEADER_ID_PK = dairyEntity.HEADER_ID_PK
                };
                _unitOfWork.DairyRepository.Insert(dairy);
                _unitOfWork.Save();
                scope.Complete();
                return dairy.HEADER_ID_PK;
            }
        }

        /// <summary>
        /// Updates a dairy
        /// </summary>
        /// <param name="dairyId"></param>
        /// <param name="dairyEntity"></param>
        /// <returns></returns>
        public bool UpdateDairy(int dairyId, BusinessEntities.DairyEntity dairyEntity)
        {
            var success = false;
            if (dairyEntity != null)
            {
                using (var scope = new TransactionScope())
                {
                    var dairy = _unitOfWork.DairyRepository.GetByID(dairyId);
                    if (dairy != null)
                    {
                        dairy.HEADER_ID_PK = dairyEntity.HEADER_ID_PK;
                        _unitOfWork.DairyRepository.Update(dairy);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// Deletes a particular dairy
        /// </summary>
        /// <param name="dairyId"></param>
        /// <returns></returns>
        public bool DeleteDairy(int dairyId)
        {
            var success = false;
            if (dairyId > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var dairy = _unitOfWork.DairyRepository.GetByID(dairyId);
                    if (dairy != null)
                    {

                        _unitOfWork.DairyRepository.Delete(dairy);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
    }
}
