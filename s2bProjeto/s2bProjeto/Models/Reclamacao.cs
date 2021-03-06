﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace s2bProjeto.Models
{
    [Table ("RECLAMACAO") ]
    public class Reclamacao
    {
        #region "atributos"
        private int reclamacaoId;
        private string titulo;
        private string descricao;
        private DateTime data;
        private string bairro;
        private string logradouro;
        private int numero;
        private string cep;
        private byte[] imagemFile;
        private string imagemMimeType;
        private string imagemUrl;
        private ICollection<Comentario> comentarios;
        private int usuarioId;
        private Usuario usuario;
        private int categoriaId;
        private Categoria categoria;
        #endregion
        #region "construtores"
        public Reclamacao() { }
        /// <summary>
        /// Constutor classe Reclamacao titulo e descricao 
        /// </summary>
        /// <param string titulo="titulo"></param>
        /// <param string descricao="descricao"></param>
        public Reclamacao (string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;

        }
        /// <summary>
        ///Construtor classe Reclamacao todos atributos
        /// </summary>
        /// <param string titulo ="titulo"></param>
        /// <param string descricao="descricao"></param>
        /// <param Datetime data="data"></param>
        /// <param string bairro="bairro"></param>
        /// /// <param string logradouro="logradouro"></param>
        /// <param int numero="numero"></param>
        /// <param string cep="cep"></param>
        /// <param string imagem="imagem"></param>
        public Reclamacao (string titulo, string descricao, DateTime data, string bairro, string logradouro, int numero, string cep): this (titulo, descricao)
        {
            Data = data;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;

        }
        #endregion
        #region "métodos públicos"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReclamacaoId
        {
            get { return reclamacaoId; }
            set { this.reclamacaoId = value; }
        }
        [Required]
        public string Titulo
        {
            get { return titulo; }
            set { this.titulo = value; }
        }
        [Required]
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
        }
        [Required]
        public DateTime Data
        {
            get { return data; }
            set { this.data = value; }
        }
        [Required]
        public string Bairro
        {
            get { return bairro; }
            set { this.bairro = value; }
        }
        [Required]
        public string Logradouro
        {
            get { return logradouro; }
            set { this.logradouro = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { this.numero = value; }
        }
        //[RegularExpression  (@"^\d{5}-\d{3}$", ErrorMessage = "Cep Inválido") ]
        public string Cep
        {
            get { return cep; }
            set { this.cep = value; }
        }
        [Display(Name = "Upload imagem")]
        public byte[] ImagemFile
        {
            get { return this.imagemFile; }
            set { this.imagemFile = value; }
        }
        public String ImagemMimeType
        {
            get { return this.imagemMimeType; }
            set { this.imagemMimeType = value; }
        }
        [Display(Name = "Image link")]
        [DataType(DataType.ImageUrl)]
        public String ImagemUrl
        {
            get { return this.imagemUrl; }
            set { this.imagemUrl = value; }
        }
        public virtual ICollection<Comentario> Comentario
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        public int UsuarioId
        {
           get { return usuarioId; }
           set { usuarioId = value; }
     }
        [ForeignKey("UsuarioId")]
        [Column(Order = 1)]
        public virtual Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public int CategoriaId
        {
            get { return categoriaId; }
            set { categoriaId = value; }
        }
        [ForeignKey("CategoriaId")]
        [Column(Order = 1)]
        public virtual Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        #endregion
    }
}