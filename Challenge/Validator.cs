namespace Challenge
{
    public class Validator
    {
        private List<string> errors;
        private Func<string, bool> validationFunction;

        public Validator(Func<string, bool> validationFunction)
        {
            errors = new List<string>();
            this.validationFunction = validationFunction;
        }

        public bool IsValid(string data)
        {
            if (!validationFunction(data))
            {
                errors.Add("Data is not valid");
            }

            return errors.Count == 0;
        }

        public bool IsValid(string data, string messageError)
        {
            if (!validationFunction(data))
            {
                errors.Add(messageError);
            }

            return errors.Count == 0;
        }

        public bool HasErrors()
        {
            return errors.Count > 0;
        }

        public List<string> GetErrors()
        {
            return errors;
        }


    }


}