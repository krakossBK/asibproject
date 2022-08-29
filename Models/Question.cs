using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asibproject
{
    /// <summary>
    /// Таблица вопросов
    /// </summary>
    [Table("question", Schema = "dbo")]
    public class Question
    {
        /// <summary>
        /// Текст Вопроса
        /// </summary>
       [Column("textquestions")]
        public string TextQuestion { get; set; }        
        /// <summary>
        /// Дата добавления
        /// </summary>
        [Column("added")]
        public DateTime Added { get; set; }
        /// <summary>
        /// ИД записи
        /// </summary>
        [Key, Column("id")]
        public int Id { get; set; }
    }
}
/*
 CREATE TABLE dbo.questions (
	textquestions varchar NOT NULL,
	added timestamp NOT NULL,
	id serial4 NOT NULL,
	CONSTRAINT questions_id_key UNIQUE (id),
	CONSTRAINT questions_pkey PRIMARY KEY (id)
);
CREATE INDEX questions_id_idx ON dbo.questions USING btree (id);
 */