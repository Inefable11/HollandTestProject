using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ApiBussinessLogic.Implementations.system_management;
using ApiBussinessLogic.Implementations.testH;
using ApiBussinessLogic.Interfaces.system_management;
using ApiBussinessLogic.Interfaces.testH;


namespace ApiCore
{
    using ApiDataAccess;
    using ApiUnitWork;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using Microsoft.Extensions.Hosting;

    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //// This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IUnitOfWork>(option => new UnitOfWork(Configuration.GetConnectionString("local")));
            services.AddTransient<ITeachersLogic, teachersLogic>();
            services.AddTransient<IStudentsLogic, studentsLogic>();
            services.AddTransient<IStaffLogic, staffLogic>();
            services.AddTransient<IDepartmentsLogic, departmentsLogic>();
            services.AddTransient<IStudentdepartamentLogic, studentDepartamentLogic>();
            services.AddTransient<ITeacherdepartamentLogic, teacherDepartamentLogic>();
            services.AddTransient<IAccesssystemLogic, accessSystemLogic>();
            services.AddTransient<IParametersLogic, parametersLogic>();
            services.AddTransient<IParameterdetailsLogic, parameterDetailsLogic>();
            services.AddTransient<ITesthollandLogic, testHollandLogic>();
            services.AddTransient<ITesthollandartisticopuedesLogic, testHollandArtisticoPuedesLogic>();
            services.AddTransient<ITesthollandartisticotegustariaLogic, testHollandArtisticoTeGustariaLogic>();
            services.AddTransient<ITesthollandsocialeresLogic, testHollandSocialEresLogic>();
            services.AddTransient<ITesthollandsocialpuedesLogic, testHollandSocialPuedesLogic>();
            services.AddTransient<ITesthollandsocialtegustariaLogic, testHollandSocialTeGustariaLogic>();
            services.AddTransient<ITesthollandemprendedoreresLogic, testHollandEmprendedorEresLogic>();
            services.AddTransient<ITesthollandemprendedorpuedesLogic, testHollandEmprendedorPuedesLogic>();
            services.AddTransient<ITesthollandemprendedortegustariaLogic, testHollandEmprendedorTeGustariaLogic>();
            services.AddTransient<ITesthollandconvencionaleresLogic, testHollandConvencionalEresLogic>();
            services.AddTransient<ITesthollandconvencionalpuedesLogic, testHollandConvencionalPuedesLogic>();
            services.AddTransient<ITesthollandconvencionaltegustariaLogic, testHollandConvencionalTeGustariaLogic>();
            services.AddTransient<ITesthollanddetailsLogic, testHollandDetailsLogic>();
            services.AddTransient<ITesthollandrealistaeresLogic, testHollandRealistaEresLogic>();
            services.AddTransient<ITesthollandrealistapuedesLogic, testHollandRealistaPuedesLogic>();
            services.AddTransient<ITesthollandrealistategustariaLogic, testHollandRealistaTeGustariaLogic>();
            services.AddTransient<ITesthollandinvestigadoreresLogic, testHollandInvestigadorEresLogic>();
            services.AddTransient<ITesthollandartisticoeresLogic, testHollandArtisticoEresLogic>();
            services.AddTransient<ITesthollandinvestigadortegustariaLogic, testHollandInvestigadorTeGustariaLogic>();
            services.AddTransient<IStudycareersLogic, studyCareersLogic>();
            services.AddTransient<IStudyinstitutionsLogic, studyInstitutionsLogic>();
            services.AddTransient<IVocationsLogic, vocationsLogic>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllOrigins",
                    builder =>
                    {
                        builder.AllowAnyHeader()
                            .AllowAnyOrigin()
                            .AllowAnyMethod();
                        //.WithOrigins("http://walter150976-001-site2.dtempurl.com/", "http://localhost:4200/");
                    });
            });

            /*services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => {
                    //options.RequireHttpsMetadata = false;
                    //options.TokenValidationParameters = tokenProvider.GetValidationParameters ();
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ClockSkew = TimeSpan.Zero,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["TokenKey"])),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.StatusCode = 401;
                                context.Response.Headers.Add("Token-Expired", "true");
                            }
                            return Task.CompletedTask;
                        }
                    };
                    
                });*/


            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_3_0);
            services.AddMvc (option => option.EnableEndpointRouting = false);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API SERVICES SEAPOV", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                        Enter 'Bearer' [space] and then your token in the text input below.
                        \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });


                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                   {
                        {
                            new OpenApiSecurityScheme
                            {
                            Reference = new OpenApiReference
                                {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                                },
                                Scheme = "oauth2",
                                Name = "Bearer",
                                In = ParameterLocation.Header,

                            },
                            new List<string>()
                            }
                   });


                #region Agrega la documentación XML de todos los proyectos referenciados que lo generen
                var currentAssembly = Assembly.GetExecutingAssembly();
                var xmlDocs = currentAssembly.GetReferencedAssemblies()
                    .Union(new AssemblyName[] { currentAssembly.GetName() })
                    .Select(a => Path.Combine(Path.GetDirectoryName(currentAssembly.Location), $"{a.Name}.xml"))
                    .Where(File.Exists).ToArray();
                Array.ForEach(xmlDocs, (d) =>
                {
                    c.IncludeXmlComments(d);
                });
                #endregion

            });

        }

        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            string ruta = Configuration["rutaFotoUser"];
            app.UseDeveloperExceptionPage();
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler("/Error");
                app.UseHsts ();
            }

            
            app.UseRouting();
            // CORS
            // https://docs.asp.net/en/latest/security/cors.html
            //app.UseHttpsRedirection ();
            /*app.UseCors(builder =>
                builder.WithOrigins(Configuration["ServerCors"])
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    );
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            
            app.UseCors("MyAllowSpecificOrigins");*/
            app.UseCors("AllOrigins");
            app.UseAuthentication ();
            app.UseAuthorization();
            app.UseStaticFiles ();
           // app.UseCookiePolicy ();
            app.UseMvc ();
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1.0"); });
            /*app.UseFileServer(new FileServerOptions
            {
                FileProvider = new PhysicalFileProvider(ruta),
                RequestPath = new PathString("/user"),
                EnableDirectoryBrowsing = true
            });*/
        }
    }
}



