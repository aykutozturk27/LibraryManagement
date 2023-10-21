namespace LibraryManagement.Business.Constants
{
    public static class Messages
    {
        #region Personal
        public static string FirstNameIsNotEmpty = "Kullanıcı adı boş geçilemez";
        public static string LastNameIsNotEmpty = "Kullanıcı soyadı boş geçilemez";
        public static string IdentityNumberIsNotEmpty = "Kullanıcı TC no boş geçilemez";
        public static string PhoneNumberIsNotEmpty = "Kullanıcı telefonu boş geçilemez";
        public static string IdentityNumberIsSmallerThanTwelve = "Kullanıcı TC no 12 haneden az olmalıdır";
        public static string PhoneNumberIsSmallerThanTwelve = "Kullanıcı TC no 12 haneden az olmalıdır";
        public static string PersonalFullNameIsNotEmpty = "Kullanıcı boş geçilemez";
        #endregion

        #region Book
        public static string BookNameIsNotEmpty = "Kitap adı boş geçilemez";
        public static string AuthorIsNotEmpty = "Kitap yazarı boş geçilemez";
        public static string ISBNIsNotEmpty = "Kitap ISBN boş geçilemez";
        public static string ReceivingDateIsNotEmpty = "Kitap veriliş tarihi boş geçilemez";
        public static string ReturnDateIsNotEmpty = "Kitap geri dönüş tarihi boş geçilemez";
        #endregion
    }
}
