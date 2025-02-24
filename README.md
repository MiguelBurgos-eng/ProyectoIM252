# Proyecto IM 25-2

**Proyecto de la materia de Implantación y Mantenimiento de Sistemas**

## 📂 Estructura del Proyecto

```tree
ProyectoIM252/
├─ ProyectoIM252.sln
├─ README.md
└─ src/
   ├─ Application/
   │  ├─ Application.csproj
   │  ├─ bin/
   │  │  └─ Debug/
   │  │     └─ net9.0/
   │  │        ├─ Application.deps.json
   │  │        ├─ Application.dll
   │  │        ├─ Application.pdb
   │  │        ├─ Domain.dll
   │  │        └─ Domain.pdb
   │  ├─ obj/
   │  │  ├─ Application.csproj.nuget.dgspec.json
   │  │  ├─ Application.csproj.nuget.g.props
   │  │  ├─ Application.csproj.nuget.g.targets
   │  │  ├─ Debug/
   │  │  │  └─ net9.0/
   │  │  │     ├─ .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
   │  │  │     ├─ Applicat.44B5EDA2.Up2Date
   │  │  │     ├─ Application.AssemblyInfo.cs
   │  │  │     ├─ Application.AssemblyInfoInputs.cache
   │  │  │     ├─ Application.assets.cache
   │  │  │     ├─ Application.csproj.AssemblyReference.cache
   │  │  │     ├─ Application.csproj.CoreCompileInputs.cache
   │  │  │     ├─ Application.csproj.FileListAbsolute.txt
   │  │  │     ├─ Application.dll
   │  │  │     ├─ Application.GeneratedMSBuildEditorConfig.editorconfig
   │  │  │     ├─ Application.GlobalUsings.g.cs
   │  │  │     ├─ Application.pdb
   │  │  │     ├─ Application.sourcelink.json
   │  │  │     ├─ ref/
   │  │  │     │  └─ Application.dll
   │  │  │     └─ refint/
   │  │  │        └─ Application.dll
   │  │  ├─ project.assets.json
   │  │  └─ project.nuget.cache
   │  └─ Services/
   │     └─ FileConverter.cs
   ├─ Domain/
   │  ├─ bin/
   │  │  └─ Debug/
   │  │     └─ net9.0/
   │  │        ├─ Domain.deps.json
   │  │        ├─ Domain.dll
   │  │        └─ Domain.pdb
   │  ├─ Domain.csproj
   │  ├─ Entities/
   │  │  ├─ Cliente.cs
   │  │  ├─ Producto.cs
   │  │  └─ Venta.cs
   │  └─ obj/
   │     ├─ Debug/
   │     │  └─ net9.0/
   │     │     ├─ .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
   │     │     ├─ Domain.AssemblyInfo.cs
   │     │     ├─ Domain.AssemblyInfoInputs.cache
   │     │     ├─ Domain.assets.cache
   │     │     ├─ Domain.csproj.CoreCompileInputs.cache
   │     │     ├─ Domain.csproj.FileListAbsolute.txt
   │     │     ├─ Domain.dll
   │     │     ├─ Domain.GeneratedMSBuildEditorConfig.editorconfig
   │     │     ├─ Domain.GlobalUsings.g.cs
   │     │     ├─ Domain.pdb
   │     │     ├─ Domain.sourcelink.json
   │     │     ├─ ref/
   │     │     │  └─ Domain.dll
   │     │     └─ refint/
   │     │        └─ Domain.dll
   │     ├─ Domain.csproj.nuget.dgspec.json
   │     ├─ Domain.csproj.nuget.g.props
   │     ├─ Domain.csproj.nuget.g.targets
   │     ├─ project.assets.json
   │     └─ project.nuget.cache
   ├─ Infrastructure/
   │  ├─ bin/
   │  │  └─ Debug/
   │  │     └─ net9.0/
   │  │        ├─ Application.dll
   │  │        ├─ Application.pdb
   │  │        ├─ Domain.dll
   │  │        ├─ Domain.pdb
   │  │        ├─ Infrastructure.deps.json
   │  │        ├─ Infrastructure.dll
   │  │        └─ Infrastructure.pdb
   │  ├─ Data/
   │  │  ├─ ClientesDbContext.cs
   │  │  ├─ ProductosDbContext.cs
   │  │  └─ VentasDbContext.cs
   │  ├─ Infrastructure.csproj
   │  └─ obj/
   │     ├─ Debug/
   │     │  └─ net9.0/
   │     │     ├─ .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
   │     │     ├─ Infrastr.15EFFBFE.Up2Date
   │     │     ├─ Infrastructure.AssemblyInfo.cs
   │     │     ├─ Infrastructure.AssemblyInfoInputs.cache
   │     │     ├─ Infrastructure.assets.cache
   │     │     ├─ Infrastructure.csproj.AssemblyReference.cache
   │     │     ├─ Infrastructure.csproj.CoreCompileInputs.cache
   │     │     ├─ Infrastructure.csproj.FileListAbsolute.txt
   │     │     ├─ Infrastructure.dll
   │     │     ├─ Infrastructure.GeneratedMSBuildEditorConfig.editorconfig
   │     │     ├─ Infrastructure.GlobalUsings.g.cs
   │     │     ├─ Infrastructure.pdb
   │     │     ├─ Infrastructure.sourcelink.json
   │     │     ├─ ref/
   │     │     │  └─ Infrastructure.dll
   │     │     └─ refint/
   │     │        └─ Infrastructure.dll
   │     ├─ Infrastructure.csproj.nuget.dgspec.json
   │     ├─ Infrastructure.csproj.nuget.g.props
   │     ├─ Infrastructure.csproj.nuget.g.targets
   │     ├─ project.assets.json
   │     └─ project.nuget.cache
   └─ Presentation.WebApp/
      ├─ appsettings.Development.json
      ├─ appsettings.json
      ├─ bin/
      │  └─ Debug/
      │     └─ net9.0/
      │        ├─ Application.dll
      │        ├─ Application.pdb
      │        ├─ appsettings.Development.json
      │        ├─ appsettings.json
      │        ├─ Azure.Core.dll
      │        ├─ Azure.Identity.dll
      │        ├─ ConvertApi.dll
      │        ├─ cs/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ de/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ Domain.dll
      │        ├─ Domain.pdb
      │        ├─ es/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ fr/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ Infrastructure.dll
      │        ├─ Infrastructure.pdb
      │        ├─ it/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ ja/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ ko/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ Microsoft.Bcl.AsyncInterfaces.dll
      │        ├─ Microsoft.Bcl.Cryptography.dll
      │        ├─ Microsoft.Data.SqlClient.dll
      │        ├─ Microsoft.Identity.Client.dll
      │        ├─ Microsoft.Identity.Client.Extensions.Msal.dll
      │        ├─ Microsoft.IdentityModel.Abstractions.dll
      │        ├─ Microsoft.IdentityModel.JsonWebTokens.dll
      │        ├─ Microsoft.IdentityModel.Logging.dll
      │        ├─ Microsoft.IdentityModel.Protocols.dll
      │        ├─ Microsoft.IdentityModel.Protocols.OpenIdConnect.dll
      │        ├─ Microsoft.IdentityModel.Tokens.dll
      │        ├─ Microsoft.SqlServer.Server.dll
      │        ├─ Microsoft.Win32.SystemEvents.dll
      │        ├─ Newtonsoft.Json.dll
      │        ├─ pl/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ Presentation.WebApp.deps.json
      │        ├─ Presentation.WebApp.dll
      │        ├─ Presentation.WebApp.exe
      │        ├─ Presentation.WebApp.pdb
      │        ├─ Presentation.WebApp.runtimeconfig.json
      │        ├─ Presentation.WebApp.staticwebassets.endpoints.json
      │        ├─ Presentation.WebApp.staticwebassets.runtime.json
      │        ├─ pt-BR/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ ru/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ runtimes/
      │        │  ├─ unix/
      │        │  │  └─ lib/
      │        │  │     └─ net9.0/
      │        │  │        └─ Microsoft.Data.SqlClient.dll
      │        │  ├─ win/
      │        │  │  └─ lib/
      │        │  │     └─ net9.0/
      │        │  │        ├─ Microsoft.Data.SqlClient.dll
      │        │  │        └─ Microsoft.Win32.SystemEvents.dll
      │        │  ├─ win-arm64/
      │        │  │  └─ native/
      │        │  │     └─ Microsoft.Data.SqlClient.SNI.dll
      │        │  ├─ win-x64/
      │        │  │  └─ native/
      │        │  │     └─ Microsoft.Data.SqlClient.SNI.dll
      │        │  └─ win-x86/
      │        │     └─ native/
      │        │        └─ Microsoft.Data.SqlClient.SNI.dll
      │        ├─ System.ClientModel.dll
      │        ├─ System.Configuration.ConfigurationManager.dll
      │        ├─ System.Drawing.Common.dll
      │        ├─ System.IdentityModel.Tokens.Jwt.dll
      │        ├─ System.Memory.Data.dll
      │        ├─ System.Private.Windows.Core.dll
      │        ├─ System.Security.Cryptography.ProtectedData.dll
      │        ├─ tr/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        ├─ zh-Hans/
      │        │  └─ Microsoft.Data.SqlClient.resources.dll
      │        └─ zh-Hant/
      │           └─ Microsoft.Data.SqlClient.resources.dll
      ├─ Controllers/
      │  ├─ ClientesController.cs
      │  ├─ HomeController.cs
      │  ├─ ProductosController.cs
      │  └─ VentasController.cs
      ├─ Models/
      │  └─ ErrorViewModel.cs
      ├─ obj/
      │  ├─ Debug/
      │  │  └─ net9.0/
      │  │     ├─ .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
      │  │     ├─ apphost.exe
      │  │     ├─ compressed/
      │  │     │  ├─ 0pa643s6nw-h1s4sie4z3.gz
      │  │     │  ├─ 0vel1p6s6n-d7shbmvgxk.gz
      │  │     │  ├─ 1gxgswon42-lcd1t2u6c8.gz
      │  │     │  ├─ 1qvci9dd8r-6cfz1n2cew.gz
      │  │     │  ├─ 2p7d2xob87-fsbi9cje9m.gz
      │  │     │  ├─ 44lryppotx-pk9g2wxc8p.gz
      │  │     │  ├─ 48dq2h3qy1-j5mq2jizvt.gz
      │  │     │  ├─ 4lerwrt3gp-61n19gt1b8.gz
      │  │     │  ├─ 51kx8gwv6a-erw9l3u2r3.gz
      │  │     │  ├─ 5qbmpqamh8-xtxxf3hu2r.gz
      │  │     │  ├─ 6xkvf0qtu7-lzl9nlhx6b.gz
      │  │     │  ├─ 720jx7f8n9-kbrnm935zg.gz
      │  │     │  ├─ 7ib4rcv6fj-rzd6atqjts.gz
      │  │     │  ├─ 7survucq6r-gtggb63hbq.gz
      │  │     │  ├─ 8tobvqpx69-tdbxkamptv.gz
      │  │     │  ├─ 8wi67tlep2-06098lyss8.gz
      │  │     │  ├─ 9xwijzcj8s-b7pk76d08c.gz
      │  │     │  ├─ a0h5cxveep-c2oey78nd0.gz
      │  │     │  ├─ a91pqq9mrr-gtggb63hbq.gz
      │  │     │  ├─ adx8gi10wo-ft3s53vfgj.gz
      │  │     │  ├─ ajcx3p7kqy-493y06b0oq.gz
      │  │     │  ├─ arwdeikv0w-2z0ns9nrw6.gz
      │  │     │  ├─ b9jgfcomwy-y7v9cxd14o.gz
      │  │     │  ├─ bn91pp0usi-b9sayid5wm.gz
      │  │     │  ├─ cd96qelldu-hrwsygsryq.gz
      │  │     │  ├─ exvn3yx7vh-mlv21k5csn.gz
      │  │     │  ├─ gltcf3cjj0-46ein0sx1k.gz
      │  │     │  ├─ gqr9or8ixc-6pdc2jztkx.gz
      │  │     │  ├─ i91dsu10bw-0i3buxo5is.gz
      │  │     │  ├─ ipnqx06qou-aexeepp0ev.gz
      │  │     │  ├─ it0jcwp9zo-c2jlpeoesf.gz
      │  │     │  ├─ jp21y3mg6s-356vix0kms.gz
      │  │     │  ├─ k4bmzceokn-mrlpezrjn3.gz
      │  │     │  ├─ k7dku61pwg-0j3bgjxly4.gz
      │  │     │  ├─ kod4979bqy-k8d9w2qqmf.gz
      │  │     │  ├─ l25o47dw6n-pj5nd1wqec.gz
      │  │     │  ├─ lmgfw39xh4-vr1egmr9el.gz
      │  │     │  ├─ lwkgj8znse-dxx9fxp4il.gz
      │  │     │  ├─ mrtl8cwwij-47otxtyo56.gz
      │  │     │  ├─ n2u905bvsb-cosvhxvwiu.gz
      │  │     │  ├─ nnos276mv3-v0zj4ognzu.gz
      │  │     │  ├─ ovy9fq66e6-notf2xhcfb.gz
      │  │     │  ├─ p3vh5bejou-ee0r1s7dh0.gz
      │  │     │  ├─ p4yz410sfv-o1o13a6vjx.gz
      │  │     │  ├─ prbghs5m8d-4v8eqarkd7.gz
      │  │     │  ├─ pvz8b49vmo-x0q3zqp4vz.gz
      │  │     │  ├─ pww4ec7e9y-iovd86k7lj.gz
      │  │     │  ├─ q9zf330r5e-bqjiyaj88i.gz
      │  │     │  ├─ qktxkkkdju-jd9uben2k1.gz
      │  │     │  ├─ rctmf7x9cy-37tfw0ft22.gz
      │  │     │  ├─ seav8kukh0-83jwlth58m.gz
      │  │     │  ├─ sk0yza1vdv-muycvpuwrr.gz
      │  │     │  ├─ t1jic56uui-ag7o75518u.gz
      │  │     │  ├─ tm46iovasx-fvhpjtyr6v.gz
      │  │     │  ├─ vfcv4nnueb-ausgxo2sd3.gz
      │  │     │  ├─ vsdoyzir3a-63fj8s7r0e.gz
      │  │     │  ├─ watkk2y9yo-ttgo8qnofa.gz
      │  │     │  ├─ wgboj0xi6n-s35ty4nyc5.gz
      │  │     │  ├─ wt974hjwve-r4e9w2rdcm.gz
      │  │     │  ├─ xa0k72b9hv-nvvlpmu67g.gz
      │  │     │  ├─ xvwjtdb308-khv3u5hwcm.gz
      │  │     │  ├─ xxv2kqxes6-ub07r2b239.gz
      │  │     │  ├─ z2xrko29qv-jj8uyg4cgr.gz
      │  │     │  └─ zt88bn47qm-87fc7y1x7t.gz
      │  │     ├─ Presenta.8A8DC120.Up2Date
      │  │     ├─ Presentation.WebApp.AssemblyInfo.cs
      │  │     ├─ Presentation.WebApp.AssemblyInfoInputs.cache
      │  │     ├─ Presentation.WebApp.assets.cache
      │  │     ├─ Presentation.WebApp.csproj.AssemblyReference.cache
      │  │     ├─ Presentation.WebApp.csproj.CoreCompileInputs.cache
      │  │     ├─ Presentation.WebApp.csproj.FileListAbsolute.txt
      │  │     ├─ Presentation.WebApp.dll
      │  │     ├─ Presentation.WebApp.GeneratedMSBuildEditorConfig.editorconfig
      │  │     ├─ Presentation.WebApp.genruntimeconfig.cache
      │  │     ├─ Presentation.WebApp.GlobalUsings.g.cs
      │  │     ├─ Presentation.WebApp.MvcApplicationPartsAssemblyInfo.cache
      │  │     ├─ Presentation.WebApp.pdb
      │  │     ├─ Presentation.WebApp.RazorAssemblyInfo.cache
      │  │     ├─ Presentation.WebApp.RazorAssemblyInfo.cs
      │  │     ├─ Presentation.WebApp.sourcelink.json
      │  │     ├─ ref/
      │  │     │  └─ Presentation.WebApp.dll
      │  │     ├─ refint/
      │  │     │  └─ Presentation.WebApp.dll
      │  │     ├─ scopedcss/
      │  │     │  ├─ bundle/
      │  │     │  │  └─ Presentation.WebApp.styles.css
      │  │     │  ├─ projectbundle/
      │  │     │  │  └─ Presentation.WebApp.bundle.scp.css
      │  │     │  └─ Views/
      │  │     │     └─ Shared/
      │  │     │        └─ _Layout.cshtml.rz.scp.css
      │  │     ├─ staticwebassets/
      │  │     │  ├─ msbuild.build.Presentation.WebApp.props
      │  │     │  ├─ msbuild.buildMultiTargeting.Presentation.WebApp.props
      │  │     │  ├─ msbuild.buildTransitive.Presentation.WebApp.props
      │  │     │  ├─ msbuild.Presentation.WebApp.Microsoft.AspNetCore.StaticWebAssetEndpoints.props
      │  │     │  └─ msbuild.Presentation.WebApp.Microsoft.AspNetCore.StaticWebAssets.props
      │  │     ├─ staticwebassets.build.endpoints.json
      │  │     ├─ staticwebassets.build.json
      │  │     ├─ staticwebassets.development.json
      │  │     └─ staticwebassets.pack.json
      │  ├─ Presentation.WebApp.csproj.nuget.dgspec.json
      │  ├─ Presentation.WebApp.csproj.nuget.g.props
      │  ├─ Presentation.WebApp.csproj.nuget.g.targets
      │  ├─ project.assets.json
      │  └─ project.nuget.cache
      ├─ Presentation.WebApp.csproj
      ├─ Program.cs
      ├─ Properties/
      │  └─ launchSettings.json
      ├─ Views/
      │  ├─ Clientes/
      │  │  ├─ Create.cshtml
      │  │  ├─ Details.cshtml
      │  │  ├─ Edit.cshtml
      │  │  └─ Index.cshtml
      │  ├─ Home/
      │  │  ├─ Index.cshtml
      │  │  └─ Privacy.cshtml
      │  ├─ Productos/
      │  │  ├─ Create.cshtml
      │  │  ├─ Details.cshtml
      │  │  ├─ Edit.cshtml
      │  │  └─ Index.cshtml
      │  ├─ Shared/
      │  │  ├─ Error.cshtml
      │  │  ├─ _Layout.cshtml
      │  │  ├─ _Layout.cshtml.css
      │  │  └─ _ValidationScriptsPartial.cshtml
      │  ├─ Ventas/
      │  │  ├─ Create.cshtml
      │  │  ├─ Details.cshtml
      │  │  ├─ Edit.cshtml
      │  │  └─ Index.cshtml
      │  ├─ _ViewImports.cshtml
      │  └─ _ViewStart.cshtml
      └─ wwwroot/
         ├─ css/
         │  └─ site.css
         ├─ favicon.ico
         ├─ js/
         │  └─ site.js
         └─ lib/
            ├─ bootstrap/
            │  ├─ dist/
            │  │  ├─ css/
            │  │  │  ├─ bootstrap-grid.css
            │  │  │  ├─ bootstrap-grid.css.map
            │  │  │  ├─ bootstrap-grid.min.css
            │  │  │  ├─ bootstrap-grid.min.css.map
            │  │  │  ├─ bootstrap-grid.rtl.css
            │  │  │  ├─ bootstrap-grid.rtl.css.map
            │  │  │  ├─ bootstrap-grid.rtl.min.css
            │  │  │  ├─ bootstrap-grid.rtl.min.css.map
            │  │  │  ├─ bootstrap-reboot.css
            │  │  │  ├─ bootstrap-reboot.css.map
            │  │  │  ├─ bootstrap-reboot.min.css
            │  │  │  ├─ bootstrap-reboot.min.css.map
            │  │  │  ├─ bootstrap-reboot.rtl.css
            │  │  │  ├─ bootstrap-reboot.rtl.css.map
            │  │  │  ├─ bootstrap-reboot.rtl.min.css
            │  │  │  ├─ bootstrap-reboot.rtl.min.css.map
            │  │  │  ├─ bootstrap-utilities.css
            │  │  │  ├─ bootstrap-utilities.css.map
            │  │  │  ├─ bootstrap-utilities.min.css
            │  │  │  ├─ bootstrap-utilities.min.css.map
            │  │  │  ├─ bootstrap-utilities.rtl.css
            │  │  │  ├─ bootstrap-utilities.rtl.css.map
            │  │  │  ├─ bootstrap-utilities.rtl.min.css
            │  │  │  ├─ bootstrap-utilities.rtl.min.css.map
            │  │  │  ├─ bootstrap.css
            │  │  │  ├─ bootstrap.css.map
            │  │  │  ├─ bootstrap.min.css
            │  │  │  ├─ bootstrap.min.css.map
            │  │  │  ├─ bootstrap.rtl.css
            │  │  │  ├─ bootstrap.rtl.css.map
            │  │  │  ├─ bootstrap.rtl.min.css
            │  │  │  └─ bootstrap.rtl.min.css.map
            │  │  └─ js/
            │  │     ├─ bootstrap.bundle.js
            │  │     ├─ bootstrap.bundle.js.map
            │  │     ├─ bootstrap.bundle.min.js
            │  │     ├─ bootstrap.bundle.min.js.map
            │  │     ├─ bootstrap.esm.js
            │  │     ├─ bootstrap.esm.js.map
            │  │     ├─ bootstrap.esm.min.js
            │  │     ├─ bootstrap.esm.min.js.map
            │  │     ├─ bootstrap.js
            │  │     ├─ bootstrap.js.map
            │  │     ├─ bootstrap.min.js
            │  │     └─ bootstrap.min.js.map
            │  └─ LICENSE
            ├─ jquery/
            │  ├─ dist/
            │  │  ├─ jquery.js
            │  │  ├─ jquery.min.js
            │  │  ├─ jquery.min.map
            │  │  ├─ jquery.slim.js
            │  │  ├─ jquery.slim.min.js
            │  │  └─ jquery.slim.min.map
            │  └─ LICENSE.txt
            ├─ jquery-validation/
            │  ├─ dist/
            │  │  ├─ additional-methods.js
            │  │  ├─ additional-methods.min.js
            │  │  ├─ jquery.validate.js
            │  │  └─ jquery.validate.min.js
            │  └─ LICENSE.md
            └─ jquery-validation-unobtrusive/
               ├─ dist/
               │  ├─ jquery.validate.unobtrusive.js
               │  └─ jquery.validate.unobtrusive.min.js
               └─ LICENSE.txt

```

---

## 🗃️ Base de Datos

### 📌 Definición de Tablas

```sql
CREATE TABLE IM252Cliente (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR(255) NOT NULL,
    [Direccion] NVARCHAR(255) NULL,
    [Telefono] NVARCHAR(50) NOT NULL,
    [Correo] NVARCHAR(255) NOT NULL,
    CONSTRAINT PK_IM252Cliente PRIMARY KEY ([Id])
);

CREATE TABLE IM252Producto (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR(255) NOT NULL,
    [Precio] SMALLMONEY NOT NULL,
    [Cantidad] TINYINT NOT NULL DEFAULT(0),
    [Foto] NVARCHAR(255) NULL,
    CONSTRAINT PK_IM252Producto PRIMARY KEY ([Id])
);

CREATE TABLE IM252ClientesVentas (
    [ClienteId] INT NOT NULL,
    [ProductoId] INT NOT NULL,
    CONSTRAINT FK_IM252ClientesVentas_IM252Cliente FOREIGN KEY ([ClienteId]) REFERENCES [IM252Cliente] ([Id]),
    CONSTRAINT FK_IM252ClientesVentas_IM252Producto FOREIGN KEY ([ProductoId]) REFERENCES [IM252Producto] ([Id])
);
```

---

## 💻 Comandos para Configuración del Proyecto

### 🏗️ Configuración del Dominio

```sh
dotnet new classlib -o ./src/Domain
rm ./src/Domain/Class1.cs
mkdir ./src/Domain/Entities
echo 'namespace Domain;' > ./src/Domain/Entities/Cliente.cs
echo 'namespace Domain;' > ./src/Domain/Entities/Producto.cs
echo 'namespace Domain;' > ./src/Domain/Entities/ClientesVentas.cs
```

### 🏗️ Configuración de la Aplicación

```sh
dotnet new classlib -o ./src/Application
rm ./src/Application/Class1.cs
dotnet add ./src/Application reference ./src/Domain
```

### 🏗️ Configuración de la Infraestructura

```sh
dotnet new classlib -o ./src/Infrastructure
rm ./src/Infrastructure/Class1.cs
mkdir ./src/Infrastructure/Data
echo 'namespace Infrastructure;' > ./src/Infrastructure/Data/ClientesDbContext.cs
echo 'namespace Infrastructure;' > ./src/Infrastructure/Data/ProductosDbContext.cs
echo 'namespace Infrastructure;' > ./src/Infrastructure/Data/ClientesVentasDbContext.cs
dotnet add ./src/Infrastructure package Microsoft.Data.SqlClient
dotnet add ./src/Infrastructure reference ./src/Application
```

### 🏗️ Configuración del Proyecto Web MVC

```sh
dotnet new mvc -o ./src/Presentation.WebApp
mkdir ./src/Presentation.WebApp/Views/Clientes
echo 'namespace Presentation.WebApp.Controllers;' > ./src/Presentation.WebApp/Controllers/ClientesController.cs
echo '@{ ViewData["Title"] = "Clientes"; }' >  ./src/Presentation.WebApp/Views/Clientes/Index.cshtml
echo '@{ ViewData["Title"] = "Clientes > Crear"; }' >  ./src/Presentation.WebApp/Views/Clientes/Create.cshtml
echo '@{ ViewData["Title"] = "Clientes > Detalle"; }' >  ./src/Presentation.WebApp/Views/Clientes/Details.cshtml
echo '@{ ViewData["Title"] = "Clientes > Editar"; }' >  ./src/Presentation.WebApp/Views/Clientes/Edit.cshtml
```

### 🏗️ Configuración de las Relaciones entre Proyectos

```sh
dotnet add ./src/Presentation.WebApp reference ./src/Application
dotnet add ./src/Presentation.WebApp reference ./src/Infrastructure
```

---

## 📝 Notas

- Este proyecto sigue la arquitectura en **capas**: _Domain_, _Application_, _Infrastructure_, y _Presentation_.
- Se utiliza **Entity Framework** para el manejo de base de datos.
- **ASP.NET MVC** para la estructura de la aplicación web.
- La base de datos se maneja en **SQL Server**.

---

## 📜 Licencia

Este proyecto es de uso académico para la materia de **Implantación y Mantenimiento de Sistemas**.

