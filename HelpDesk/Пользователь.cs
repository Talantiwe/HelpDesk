//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDesk
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователь
    {
        public int Id_Пользователь { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public Nullable<int> Тип { get; set; }
        public string Email { get; set; }
    
        public virtual Тип_пользователя Тип_пользователя { get; set; }
    }
}
