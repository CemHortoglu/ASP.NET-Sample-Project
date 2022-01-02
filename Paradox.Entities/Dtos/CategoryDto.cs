using Paradox.Entities.Concrete;
using Paradox.Shared.Entities.Abstract;
using Paradox.Shared.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Entities.Dtos
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
    public class CategoryListDto : DtoGetBase
    {
        public IList<Category> Category { get; set; }
    }
    public class CategoryAddDto
    {
        [Display(ResourceType = typeof(Localization), Name = "Title")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        public string Title { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Description")]
        public string Description { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Keyword")]
        public string Keyword { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "IsItActive")]
        public bool IsActive { get; set; }
    }
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Title")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        public string Title { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Description")]
        public string Description { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Keyword")]
        public string Keyword { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "IsItActive")]
        public bool IsActive { get; set; }
    }
}
