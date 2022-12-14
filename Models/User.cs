using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asibproject
{
    /// <summary>
    /// ??????? ?????????????
    /// </summary>
    [Table("users", Schema = "dbo")]
    public class User
    {
        /// <summary>
        /// ???
        /// </summary>
       [Column("firstname")]
        public string FirstName { get; set; }
        /// <summary>
        /// ???????
        /// </summary>
        [Column("lastname")]
        public string LastName { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        [Column("patrname")]
        public string PatrName { get; set; }
        /// <summary>
        /// ???? ??????????
        /// </summary>
        [Column("added")]
        public DateTime Added { get; set; }
        /// <summary>
        /// ?? ??????
        /// </summary>
        [Key, Column("id")]
        public int Id { get; set; }
    }
}