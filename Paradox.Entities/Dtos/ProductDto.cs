using Microsoft.Extensions.Localization;
using Paradox.Entities.Concrete;
using Paradox.Shared.Attributes;
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

    public class ProductDto : DtoGetBase
    {
        public Product Product { get; set; }
    }
    public class ProductListDto : DtoGetBase
    {
        public IList<Product> Products { get; set; }
    }

    public class ProductAddDto
    {

        [Display(ResourceType = typeof(Localization), Name = "Title")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [CustomRequired]

        [MaxLength(100, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(5, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Title { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Contents")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MinLength(20, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Content { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Thumbnail")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MaxLength(250, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(5, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Thumbnail { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Description")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MaxLength(150, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(0, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Description { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Keyword")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MaxLength(70, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(5, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Keyword { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Category")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "IsItActive")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        public bool IsActive { get; set; }
    }
    public class ProductUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Title")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(5, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Title { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Contents")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MinLength(20, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Content { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Thumbnail")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MaxLength(250, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(5, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Thumbnail { get; set; }

        [Display(ResourceType = typeof(Localization), Name = "Description")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MaxLength(150, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(0, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Description { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Keyword")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        [MaxLength(70, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeGreaterThanCharacter")]
        [MinLength(5, ErrorMessageResourceType = typeof(Localization), ErrorMessage = "MustNotBeLessThanCharacter")]
        public string Keyword { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "Category")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Display(ResourceType = typeof(Localization), Name = "IsItActive")]
        [Required(ErrorMessageResourceType = typeof(Localization), ErrorMessage = "FieldShouldNotBeEmpty")]
        public bool IsActive { get; set; }
    }
}
