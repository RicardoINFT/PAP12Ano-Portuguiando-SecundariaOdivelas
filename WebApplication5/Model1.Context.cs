﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InstaLocalEntities2 : DbContext
    {
        public InstaLocalEntities2()
            : base("name=InstaLocalEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Comentario_Classificacao> Comentario_Classificacao { get; set; }
        public virtual DbSet<Comida> Comidas { get; set; }
        public virtual DbSet<Foto> Fotoes { get; set; }
        public virtual DbSet<Local> Locals { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Segue> Segues { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Utilizador> Utilizadors { get; set; }
        public virtual DbSet<Visitar> Visitars { get; set; }
    
        public virtual ObjectResult<ComentariosProc_Result> ComentariosProc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ComentariosProc_Result>("ComentariosProc");
        }
    
        public virtual ObjectResult<ComidaProc_Result> ComidaProc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ComidaProc_Result>("ComidaProc");
        }
    
        public virtual int DeletComida(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletComida", iDParameter);
        }
    
        public virtual int DeleteComentarios(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteComentarios", iDParameter);
        }
    
        public virtual int DeleteLocal(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteLocal", iDParameter);
        }
    
        public virtual int Deletesegue(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Deletesegue", iDParameter);
        }
    
        public virtual int DeleteVisitar(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteVisitar", iDParameter);
        }
    
        public virtual int DeletFoto(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletFoto", iDParameter);
        }
    
        public virtual int DeletUtilizador(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletUtilizador", iDParameter);
        }
    
        public virtual ObjectResult<FotoProc_Result> FotoProc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FotoProc_Result>("FotoProc");
        }
    
        public virtual ObjectResult<ImagensPorId_Result> ImagensPorId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ImagensPorId_Result>("ImagensPorId");
        }
    
        public virtual int Insertcomentarios(string comentarios, Nullable<System.DateTime> data, Nullable<int> classificacao, Nullable<System.TimeSpan> hora, Nullable<int> local, Nullable<int> utilizador)
        {
            var comentariosParameter = comentarios != null ?
                new ObjectParameter("comentarios", comentarios) :
                new ObjectParameter("comentarios", typeof(string));
    
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            var classificacaoParameter = classificacao.HasValue ?
                new ObjectParameter("classificacao", classificacao) :
                new ObjectParameter("classificacao", typeof(int));
    
            var horaParameter = hora.HasValue ?
                new ObjectParameter("hora", hora) :
                new ObjectParameter("hora", typeof(System.TimeSpan));
    
            var localParameter = local.HasValue ?
                new ObjectParameter("local", local) :
                new ObjectParameter("local", typeof(int));
    
            var utilizadorParameter = utilizador.HasValue ?
                new ObjectParameter("utilizador", utilizador) :
                new ObjectParameter("utilizador", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insertcomentarios", comentariosParameter, dataParameter, classificacaoParameter, horaParameter, localParameter, utilizadorParameter);
        }
    
        public virtual int insertComida(string codigopostal, string facebook, byte[] foto, Nullable<int> iD, string instagram, string localidade, Nullable<int> local1, string morada, string nome, string telefone, string uRLs)
        {
            var codigopostalParameter = codigopostal != null ?
                new ObjectParameter("codigopostal", codigopostal) :
                new ObjectParameter("codigopostal", typeof(string));
    
            var facebookParameter = facebook != null ?
                new ObjectParameter("Facebook", facebook) :
                new ObjectParameter("Facebook", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(byte[]));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var instagramParameter = instagram != null ?
                new ObjectParameter("Instagram", instagram) :
                new ObjectParameter("Instagram", typeof(string));
    
            var localidadeParameter = localidade != null ?
                new ObjectParameter("Localidade", localidade) :
                new ObjectParameter("Localidade", typeof(string));
    
            var local1Parameter = local1.HasValue ?
                new ObjectParameter("Local1", local1) :
                new ObjectParameter("Local1", typeof(int));
    
            var moradaParameter = morada != null ?
                new ObjectParameter("Morada", morada) :
                new ObjectParameter("Morada", typeof(string));
    
            var nomeParameter = nome != null ?
                new ObjectParameter("Nome", nome) :
                new ObjectParameter("Nome", typeof(string));
    
            var telefoneParameter = telefone != null ?
                new ObjectParameter("Telefone", telefone) :
                new ObjectParameter("Telefone", typeof(string));
    
            var uRLsParameter = uRLs != null ?
                new ObjectParameter("URLs", uRLs) :
                new ObjectParameter("URLs", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertComida", codigopostalParameter, facebookParameter, fotoParameter, iDParameter, instagramParameter, localidadeParameter, local1Parameter, moradaParameter, nomeParameter, telefoneParameter, uRLsParameter);
        }
    
        public virtual int Insertfoto(Nullable<int> iD, string ficheiro, string legenda, Nullable<int> local1)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var ficheiroParameter = ficheiro != null ?
                new ObjectParameter("Ficheiro", ficheiro) :
                new ObjectParameter("Ficheiro", typeof(string));
    
            var legendaParameter = legenda != null ?
                new ObjectParameter("Legenda", legenda) :
                new ObjectParameter("Legenda", typeof(string));
    
            var local1Parameter = local1.HasValue ?
                new ObjectParameter("local1", local1) :
                new ObjectParameter("local1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insertfoto", iDParameter, ficheiroParameter, legendaParameter, local1Parameter);
        }
    
        public virtual int InsertLocal(Nullable<int> utilizador, string nome, string morada, string codigopostal, string localidade, string longitude, string latitude, string descricao, string what3words, string foto, string video, string tipo)
        {
            var utilizadorParameter = utilizador.HasValue ?
                new ObjectParameter("utilizador", utilizador) :
                new ObjectParameter("utilizador", typeof(int));
    
            var nomeParameter = nome != null ?
                new ObjectParameter("nome", nome) :
                new ObjectParameter("nome", typeof(string));
    
            var moradaParameter = morada != null ?
                new ObjectParameter("morada", morada) :
                new ObjectParameter("morada", typeof(string));
    
            var codigopostalParameter = codigopostal != null ?
                new ObjectParameter("codigopostal", codigopostal) :
                new ObjectParameter("codigopostal", typeof(string));
    
            var localidadeParameter = localidade != null ?
                new ObjectParameter("localidade", localidade) :
                new ObjectParameter("localidade", typeof(string));
    
            var longitudeParameter = longitude != null ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(string));
    
            var latitudeParameter = latitude != null ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            var what3wordsParameter = what3words != null ?
                new ObjectParameter("what3words", what3words) :
                new ObjectParameter("what3words", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(string));
    
            var videoParameter = video != null ?
                new ObjectParameter("video", video) :
                new ObjectParameter("video", typeof(string));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertLocal", utilizadorParameter, nomeParameter, moradaParameter, codigopostalParameter, localidadeParameter, longitudeParameter, latitudeParameter, descricaoParameter, what3wordsParameter, fotoParameter, videoParameter, tipoParameter);
        }
    
        public virtual int insertSegue(Nullable<int> iD, Nullable<int> segueUtilizador, Nullable<int> seguidopor)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var segueUtilizadorParameter = segueUtilizador.HasValue ?
                new ObjectParameter("segueUtilizador", segueUtilizador) :
                new ObjectParameter("segueUtilizador", typeof(int));
    
            var seguidoporParameter = seguidopor.HasValue ?
                new ObjectParameter("seguidopor", seguidopor) :
                new ObjectParameter("seguidopor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertSegue", iDParameter, segueUtilizadorParameter, seguidoporParameter);
        }
    
        public virtual int InsertUtilizador(Nullable<int> iD, string foto, string nome, string email, string userid)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(string));
    
            var nomeParameter = nome != null ?
                new ObjectParameter("Nome", nome) :
                new ObjectParameter("Nome", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var useridParameter = userid != null ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUtilizador", iDParameter, fotoParameter, nomeParameter, emailParameter, useridParameter);
        }
    
        public virtual int InsertVisitar(Nullable<int> local1, Nullable<int> user1)
        {
            var local1Parameter = local1.HasValue ?
                new ObjectParameter("local1", local1) :
                new ObjectParameter("local1", typeof(int));
    
            var user1Parameter = user1.HasValue ?
                new ObjectParameter("user1", user1) :
                new ObjectParameter("user1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertVisitar", local1Parameter, user1Parameter);
        }
    
        public virtual ObjectResult<Local1Proc_Result> Local1Proc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Local1Proc_Result>("Local1Proc");
        }
    
        public virtual ObjectResult<ProcVisitar_Result> ProcVisitar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcVisitar_Result>("ProcVisitar");
        }
    
        public virtual ObjectResult<segueProc_Result> segueProc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<segueProc_Result>("segueProc");
        }
    
        public virtual int Updatecomentarios(string comentarios, Nullable<System.DateTime> data, Nullable<int> classificacao, Nullable<int> iD, Nullable<System.TimeSpan> hora, Nullable<int> local, Nullable<int> utilizador)
        {
            var comentariosParameter = comentarios != null ?
                new ObjectParameter("comentarios", comentarios) :
                new ObjectParameter("comentarios", typeof(string));
    
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            var classificacaoParameter = classificacao.HasValue ?
                new ObjectParameter("classificacao", classificacao) :
                new ObjectParameter("classificacao", typeof(int));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var horaParameter = hora.HasValue ?
                new ObjectParameter("hora", hora) :
                new ObjectParameter("hora", typeof(System.TimeSpan));
    
            var localParameter = local.HasValue ?
                new ObjectParameter("local", local) :
                new ObjectParameter("local", typeof(int));
    
            var utilizadorParameter = utilizador.HasValue ?
                new ObjectParameter("utilizador", utilizador) :
                new ObjectParameter("utilizador", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Updatecomentarios", comentariosParameter, dataParameter, classificacaoParameter, iDParameter, horaParameter, localParameter, utilizadorParameter);
        }
    
        public virtual int Updatecomida(string codigopostal, string facebook, byte[] foto, Nullable<int> iD, string instagram, string localidade, Nullable<int> local1, string morada, string nome, string telefone, string uRLs)
        {
            var codigopostalParameter = codigopostal != null ?
                new ObjectParameter("codigopostal", codigopostal) :
                new ObjectParameter("codigopostal", typeof(string));
    
            var facebookParameter = facebook != null ?
                new ObjectParameter("Facebook", facebook) :
                new ObjectParameter("Facebook", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(byte[]));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var instagramParameter = instagram != null ?
                new ObjectParameter("Instagram", instagram) :
                new ObjectParameter("Instagram", typeof(string));
    
            var localidadeParameter = localidade != null ?
                new ObjectParameter("Localidade", localidade) :
                new ObjectParameter("Localidade", typeof(string));
    
            var local1Parameter = local1.HasValue ?
                new ObjectParameter("Local1", local1) :
                new ObjectParameter("Local1", typeof(int));
    
            var moradaParameter = morada != null ?
                new ObjectParameter("Morada", morada) :
                new ObjectParameter("Morada", typeof(string));
    
            var nomeParameter = nome != null ?
                new ObjectParameter("Nome", nome) :
                new ObjectParameter("Nome", typeof(string));
    
            var telefoneParameter = telefone != null ?
                new ObjectParameter("Telefone", telefone) :
                new ObjectParameter("Telefone", typeof(string));
    
            var uRLsParameter = uRLs != null ?
                new ObjectParameter("URLs", uRLs) :
                new ObjectParameter("URLs", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Updatecomida", codigopostalParameter, facebookParameter, fotoParameter, iDParameter, instagramParameter, localidadeParameter, local1Parameter, moradaParameter, nomeParameter, telefoneParameter, uRLsParameter);
        }
    
        public virtual int UpdateSegue(Nullable<int> iD, Nullable<int> segueUtilizador, Nullable<int> seguidopor)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var segueUtilizadorParameter = segueUtilizador.HasValue ?
                new ObjectParameter("segueUtilizador", segueUtilizador) :
                new ObjectParameter("segueUtilizador", typeof(int));
    
            var seguidoporParameter = seguidopor.HasValue ?
                new ObjectParameter("seguidopor", seguidopor) :
                new ObjectParameter("seguidopor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSegue", iDParameter, segueUtilizadorParameter, seguidoporParameter);
        }
    
        public virtual int UpdateUtilizador(Nullable<int> iD, string nome, string email, string userid)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nomeParameter = nome != null ?
                new ObjectParameter("Nome", nome) :
                new ObjectParameter("Nome", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var useridParameter = userid != null ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUtilizador", iDParameter, nomeParameter, emailParameter, useridParameter);
        }
    
        public virtual ObjectResult<UtilizadorProc_Result> UtilizadorProc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UtilizadorProc_Result>("UtilizadorProc");
        }
    }
}
