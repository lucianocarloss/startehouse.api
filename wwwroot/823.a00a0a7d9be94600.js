"use strict";(self.webpackChunkStart_Com=self.webpackChunkStart_Com||[]).push([[823],{5823:(O,g,i)=>{i.r(g),i.d(g,{LoginModule:()=>M});var r=i(2382),c=i(5358),o=i(1223),s=i(294),m=i(2290),f=i(2313),d=i(9808),u=i(5707);function p(n,l){1&n&&(o.TgZ(0,"div",14),o._uU(1,"Email deve conter pelo meno 9 caracteres"),o.qZA())}function h(n,l){1&n&&(o.TgZ(0,"div",14),o._uU(1,"Senha deve conter pelo meno 4 caracteres"),o.qZA())}const C=[{path:"",component:(()=>{class n{constructor(t,e,a,_,x,P){this.fb=t,this.router=e,this.route=a,this.loginService=_,this.toast=x,this.titleService=P,this.title="angulartitle",this.LoadScreen=!1,this.form=this.startPage()}ngOnInit(){}startPage(){return this.fb.group({Email:["",[r.kI.required,r.kI.minLength(5)]],Senha:["",[r.kI.required,r.kI.minLength(4)]]})}isFormControlValid(t){var e,a;return!(!(null===(e=this.form.get(t))||void 0===e?void 0:e.invalid)||!(null===(a=this.form.get(t))||void 0===a?void 0:a.touched))}submitForm(){const{Email:t,Senha:e}=this.form.value;this.form.reset(),Promise.resolve().then(()=>this.LoadScreen=!0),this.loginService.login(t,e).subscribe(a=>{this.toast.success("Login efetuado com sucesso!"),this.router.navigate(["mu/home"])},a=>{this.toast.error(0==a.status?"Falha na comunica\xe7\xe3o com servidor!":a.error),this.LoadScreen=!1})}onSubmitSuccess(){this.router.navigate(["mu/home"])}onSubmit(t){this.form.valid&&this.router.navigate(["mu/home"])}}return n.\u0275fac=function(t){return new(t||n)(o.Y36(r.qu),o.Y36(c.F0),o.Y36(c.gz),o.Y36(s.j),o.Y36(m._W),o.Y36(f.Dx))},n.\u0275cmp=o.Xpm({type:n,selectors:[["ng-component"]],decls:21,vars:5,consts:[[1,"container","d-flex","justify-content-center"],[1,"col-4"],[1,"card","shadows","round","mt-5"],[1,"card-header"],[1,"text-center"],[1,"card-body"],[3,"formGroup","ngSubmit"],[1,"mb-3"],["for","",1,"form-label"],["type","email","formControlName","Email",1,"form-control"],["class","formtext text-danger",4,"ngIf"],["type","password","formControlName","Senha",1,"form-control"],[1,"btn","btn-primary",3,"disabled"],[3,"showLoadScreen"],[1,"formtext","text-danger"]],template:function(t,e){1&t&&(o.TgZ(0,"div",0),o.TgZ(1,"div",1),o.TgZ(2,"div",2),o.TgZ(3,"div",3),o.TgZ(4,"H3",4),o._uU(5,"StartCom"),o.qZA(),o.qZA(),o.TgZ(6,"div",5),o.TgZ(7,"form",6),o.NdJ("ngSubmit",function(){return e.submitForm()}),o.TgZ(8,"div",7),o.TgZ(9,"label",8),o._uU(10,"Usu\xe1rio"),o.qZA(),o._UZ(11,"input",9),o.YNc(12,p,2,0,"div",10),o.qZA(),o.TgZ(13,"div",7),o.TgZ(14,"label",8),o._uU(15,"Senha"),o.qZA(),o._UZ(16,"input",11),o.YNc(17,h,2,0,"div",10),o.qZA(),o.TgZ(18,"button",12),o._uU(19," Entrar "),o.qZA(),o.qZA(),o._UZ(20,"app-load-screen",13),o.qZA(),o.qZA(),o.qZA(),o.qZA()),2&t&&(o.xp6(7),o.Q6J("formGroup",e.form),o.xp6(5),o.Q6J("ngIf",e.isFormControlValid("Email")),o.xp6(5),o.Q6J("ngIf",e.isFormControlValid("Senha")),o.xp6(1),o.Q6J("disabled",!e.form.valid),o.xp6(2),o.Q6J("showLoadScreen",e.LoadScreen))},directives:[r._Y,r.JL,r.sg,r.Fj,r.JJ,r.u,d.O5,u.K],styles:["*[_ngcontent-%COMP%]{font-family:inter-regular,serif!important}._login-dark[_ngcontent-%COMP%]{height:100vh;background-image:linear-gradient(to bottom left,#460e0027,#f14709,#a81414);background-size:cover;position:relative;display:flex;justify-content:center;align-content:center;align-items:center}._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]{max-width:320px;width:90%;background-color:#f7f3f3;padding:40px;border-radius:10px;position:absolute;color:gray;box-shadow:3px 3px 4px #0003;height:initial!important}._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   ._form-control[_ngcontent-%COMP%]{background:none;border:none;border-bottom:1px solid #434a52;border-radius:0;box-shadow:none;outline:none;color:inherit}._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   ._forgot[_ngcontent-%COMP%]{display:block;text-align:center;font-size:12px;color:#6f7a85;opacity:.9;text-decoration:none}._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   .btn-primary[_ngcontent-%COMP%]{background:#f7f3f3;border:none;border-radius:4px;padding:11px;box-shadow:none;margin-top:26px;text-shadow:none;outline:none}._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   .btn-primary[_ngcontent-%COMP%]:hover, ._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   .btn-primary[_ngcontent-%COMP%]:active{background:#f7f3f3;outline:none}._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   .forgot[_ngcontent-%COMP%]:hover, ._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   .forgot[_ngcontent-%COMP%]:active{opacity:1;text-decoration:none}._login-dark[_ngcontent-%COMP%]   form[_ngcontent-%COMP%]   .btn-primary[_ngcontent-%COMP%]:active{transform:translateY(1px)}._login-dark[_ngcontent-%COMP%]   ._div-load[_ngcontent-%COMP%]{position:absolute;width:100%;height:100%;background-color:#00000080}._login-dark[_ngcontent-%COMP%]   ._div-load[_ngcontent-%COMP%]   ._div-load-box[_ngcontent-%COMP%]{text-align:center;transform:translate(-50%,-50%);position:absolute;top:50%;left:50%;background-color:#f7f3f3;padding:40px;border-radius:10px;box-shadow:3px 3px 4px #0003}._login-dark[_ngcontent-%COMP%]   ._illustration[_ngcontent-%COMP%]{text-align:center;padding:0;font-size:100px;color:#f14709}.btn-outline-primary[_ngcontent-%COMP%]{color:#f14709!important;border-color:#f14709!important;outline:none!important;box-shadow:none!important}.btn-outline-primary[_ngcontent-%COMP%]:hover{background-color:#15f109!important;color:#f7f3f3!important;outline:none!important;box-shadow:none!important}.text-primary[_ngcontent-%COMP%]{color:#f14709!important}.hide[_ngcontent-%COMP%]{display:none!important}._full-width[_ngcontent-%COMP%]{width:100%!important}  .mat-error{display:block;line-height:normal!important;letter-spacing:.3px}  .mat-focused .mat-form-field-label{color:#f14709!important}  .mat-form-field-ripple{background-color:#f14709!important}"]}),n})()}];let v=(()=>{class n{}return n.\u0275fac=function(t){return new(t||n)},n.\u0275mod=o.oAB({type:n}),n.\u0275inj=o.cJS({imports:[[c.Bz.forChild(C)],c.Bz]}),n})();var b=i(4466);let M=(()=>{class n{}return n.\u0275fac=function(t){return new(t||n)},n.\u0275mod=o.oAB({type:n}),n.\u0275inj=o.cJS({imports:[[d.ez,v,r.UX,c.Bz,b.m]]}),n})()}}]);