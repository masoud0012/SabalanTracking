namespace SabalanTracking.Models.IRepository
{
    public interface IRepoGeneric<TModel> where TModel : BaseModel
    {
        /// <summary>
        /// To add new TModel request object to database
        /// </summary>
        /// <param name="productAddRequest">ProductAddRequest</param>
        /// <returns>Returns new TModel object</returns>
        Task<TModel> Add(TModel product);

        /// <summary>
        /// To return a list of TModel objects 
        /// </summary>
        /// <returns>a list of TModel</returns>
        Task<IQueryable<TModel>> GetAllAsync(int start = 0, int length = 50);

        /// <summary>
        /// search for a TModel object based on a guid ID
        /// </summary>
        /// <param name="guid">TModel.ID</param>
        /// <returns>returns a TModel object </returns>
        Task<IQueryable<TModel?>> GetById(int id);

        /// <summary>
        /// To Remove TEntiry objectfrom database
        /// </summary>
        /// <param name="obj">TEntiry</param>
        /// <returns>Returns TRue if obj deleted else fals</returns>
        Task<bool> Delete(TModel obj);
        /// <summary>
        /// To update obj of TEntiry from database
        /// </summary>
        /// <param name="obj">TModel</param>
        /// <returns>Returns an object of TModel</returns>
        Task<TModel?> Update(TModel obj);
    }
}
