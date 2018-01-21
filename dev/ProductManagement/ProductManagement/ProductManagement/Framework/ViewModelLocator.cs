using ProductManagement.Repositories;
using ProductManagement.ViewModels;

namespace ProductManagement.Framework
{
    public class ViewModelLocator
    {
        public ApplicationViewModel ApplicationViewModel => new ApplicationViewModel();

        public ProductListViewModel ProductListViewModel
        {
            get
            {
                var repository = new ProductRepository();
                return new ProductListViewModel(repository);
            }
        }
    }
}
