using System;

namespace LojaVirtual.Model
{
    public class UserVO
    {
        public string Login { get; set; }
        public string AccessKey { get; set; }
        public string Name { get;  set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
