using static Homework15_Library.DelegateHolder;

namespace Homework15_Library
{
    public static class Validation
    {
        private static MessageHandler _message;
        private static InputTypeHandler _input;


        public static void SetMessageHandler(MessageHandler handler)
        {
            _message = handler;
        }

        public static void SetInputTypeHandler(InputTypeHandler handler)
        {
            _input = handler;
        }

        public static int DoIntValidation()
        {
            if (int.TryParse(_input(), out int res))
            {
                return res;
            }
            else
            {
                _message("Wrong input: not a number. Try again: ");
                return DoIntValidation();
            }
        }
    }
}
