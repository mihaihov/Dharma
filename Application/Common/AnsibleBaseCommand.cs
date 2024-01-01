using FluentValidation.Results;
namespace Application.Common
{
    public class AnsibleBaseCommand
    {
        public string PlaybookExecutorName { get; set; } = string.Empty;

        public async Task<ValidationResult> Validate()
        {
            var validator = new AnsibleBaseCommandValidator();
            var result = await validator.ValidateAsync(this);

            return result;
        }
    }
}
