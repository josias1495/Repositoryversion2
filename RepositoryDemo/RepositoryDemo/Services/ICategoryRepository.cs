using RepositoryDemo.Models;
using System.Collections.Generic;

namespace RepositoryDemo.Services
{
    public interface ICategoryRepository
    {
        void AddNewCategory(Category newCategory);

        List<Category> GetCategories();
    }
}
