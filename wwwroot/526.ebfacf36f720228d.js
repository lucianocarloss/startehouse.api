"use strict";(self.webpackChunkStart_Com=self.webpackChunkStart_Com||[]).push([[526],{526:(Y,c,s)=>{s.r(c),s.d(c,{ClientesModule:()=>U});var u=s(9808),l=s(5358),t=s(1223),d=s(6176),h=s(4004),m=s(2340);class p{constructor(i,n,o,a,r,b,y,q,O,F,x,E,L,M,R,N){this.id=i,this.nome=n,this.endereco=o,this.numero=a,this.bairro=r,this.cidade=b,this.estado=y,this.rg=q,this.cpf=O,this.telefone=F,this.celular=x,this.email=E,this.nascimento=L,this.dataCriacao=M,this.dataEdicao=R,this.status=N}}var Z=s(520);let C=(()=>{class e{constructor(n){this.http=n}load(){return this.http.get(`${m.N.baseUrlbackend}/Clientes?api-version=1.0`).pipe((0,h.U)(this.mapToClientes))}mapToClientes(n){const o=[];return n.forEach(a=>{o.push(Object.assign(new p,a))}),o}}return e.\u0275fac=function(n){return new(n||e)(t.LFG(Z.eN))},e.\u0275prov=t.Yz7({token:e,factory:e.\u0275fac,providedIn:"root"}),e})();var f=s(2290),g=s(5707);function A(e,i){if(1&e&&(t.TgZ(0,"tr",3),t.TgZ(1,"td"),t._uU(2),t.qZA(),t.TgZ(3,"td"),t._uU(4),t.qZA(),t.TgZ(5,"td"),t._uU(6),t.qZA(),t.TgZ(7,"td"),t.TgZ(8,"a",8),t._UZ(9,"i",9),t.qZA(),t._uU(10," \xa0 "),t.TgZ(11,"a",10),t._UZ(12,"i",11),t.qZA(),t._uU(13," \xa0 "),t.TgZ(14,"button",12),t._UZ(15,"i",13),t.qZA(),t.qZA(),t.qZA()),2&e){const n=i.$implicit;t.xp6(2),t.Oqu(n.id),t.xp6(2),t.Oqu(n.nome),t.xp6(2),t.Oqu(n.email)}}const v=[{path:"",component:(()=>{class e{constructor(n,o,a,r){this.mainComponent=n,this.ClientesService=o,this.Router=a,this.toast=r,this.SESSION_STORAGE="administracao",this.SESSION_STORAGE_SUB="clientes",this.listClientes=[],this.LoadScreen=!1,this.mainComponent.module="administracao",this.mainComponent.module_sub="clientes"}ngOnInit(){Promise.resolve().then(()=>this.LoadScreen=!0),this.ClientesService.load().subscribe(n=>{this.listClientes=n,this.LoadScreen=!1},n=>{401==n.status&&this.toast.error("conex\xe3o expirada!"),this.Router.navigate(["login"])})}}return e.\u0275fac=function(n){return new(n||e)(t.Y36(d.C),t.Y36(C),t.Y36(l.F0),t.Y36(f._W))},e.\u0275cmp=t.Xpm({type:e,selectors:[["app-clientes"]],decls:20,vars:2,consts:[[1,"fa-solid","fa-users-line","pe-2"],[1,"table-responsive","pt-3"],[1,"table"],[1,"text-center"],[1,"btn","btn-sm","btn-outline-success"],["aria-hidden","true",1,"fa","fa-plus"],["class","text-center",4,"ngFor","ngForOf"],[3,"showLoadScreen"],["routerLink","#",1,"btn","btn-outline-primary","btn-sm"],[1,"fa-solid","fa-eye"],["href","#",1,"btn","btn-sm","btn-outline-success"],[1,"fa-solid","fa-pen-to-square"],["type","button","href","#",1,"btn","btn-sm","btn-outline-danger"],[1,"fa-solid","fa-trash-can"]],template:function(n,o){1&n&&(t.TgZ(0,"h2"),t._UZ(1,"i",0),t._uU(2,"Clientes"),t.qZA(),t.TgZ(3,"div",1),t.TgZ(4,"table",2),t.TgZ(5,"thead"),t.TgZ(6,"tr",3),t.TgZ(7,"th"),t._uU(8,"Id"),t.qZA(),t.TgZ(9,"th"),t._uU(10,"Nome"),t.qZA(),t.TgZ(11,"th"),t._uU(12,"Email"),t.qZA(),t.TgZ(13,"th"),t._uU(14," A\xe7\u014des \xa0 "),t.TgZ(15,"button",4),t._UZ(16,"i",5),t.qZA(),t.qZA(),t.qZA(),t.qZA(),t.TgZ(17,"tbody"),t.YNc(18,A,16,3,"tr",6),t.qZA(),t.qZA(),t._UZ(19,"app-load-screen",7),t.qZA()),2&n&&(t.xp6(18),t.Q6J("ngForOf",o.listClientes),t.xp6(1),t.Q6J("showLoadScreen",o.LoadScreen))},directives:[u.sg,l.yS,g.K],styles:[""]}),e})()}];let S=(()=>{class e{}return e.\u0275fac=function(n){return new(n||e)},e.\u0275mod=t.oAB({type:e}),e.\u0275inj=t.cJS({imports:[[l.Bz.forChild(v)],l.Bz]}),e})();var T=s(4466);let U=(()=>{class e{}return e.\u0275fac=function(n){return new(n||e)},e.\u0275mod=t.oAB({type:e}),e.\u0275inj=t.cJS({imports:[[u.ez,S,T.m]]}),e})()}}]);