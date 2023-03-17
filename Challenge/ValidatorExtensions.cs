namespace Challenge
{
    public static class ValidatorExtensions
    {
        public static string GetErrorMessages(this Validator validator)
        {
            return string.Join(", ", validator.GetErrors());
        }

    }

}