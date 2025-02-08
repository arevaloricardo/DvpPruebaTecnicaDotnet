
<p align="center">
  <img src="https://cdn.prod.website-files.com/659d68c6da3f511b9d5f58f7/65b9585a085656d99065862f_Logo-double-v-partners.png" width="150" alt="Double V Partner Logo" />
  <img src="https://upload.wikimedia.org/wikipedia/commons/5/5e/Logo_bg_2020.png" width="150" alt="Banco Guayaquil Logo" />
</p>

# Api Restful .Net | Prueba Técnica


<div >
    <img src="https://img.shields.io/badge/.Net-9.0-red?labelColor=7455dd&color=black" alt="NPM Version" />
<img src="https://img.shields.io/badge/Entity Framework-9.0.1-red?labelColor=3e2bd1&color=black" alt="NPM Version" />
<img src="https://img.shields.io/badge/Swagger-7.2.0-red?labelColor=85ea2d&color=black" alt="NPM Version" />
<img src="https://img.shields.io/badge/Docker-2.32.0-red?labelColor=7455dd&color=black" alt="NPM Version" />
<img src="https://img.shields.io/badge/SQL Server-16.0-red?labelColor=7455dd&color=black" alt="NPM Version" />
</div>



### Descripción
Api Rest desarrollada en .Net Core 9.0, con Entity Framework, Swagger, Docker y SQL Server. Se aplicaron principios S.O.L.I.D, arquitectura hexagonal y buenas prácticas de programación. 

### Requisitos
- [.Net 9.0](https://dotnet.microsoft.com/es-es/download)
- [Docker](https://www.docker.com/)

### Instalación

1. Clonar el repositorio

```bash
git clone "nombre del repositorio"
```

2. Ingresar a la carpeta del proyecto

```bash
cd DvpPruebaTecnica.Api
```

3. Ejecutar el proyecto. (Se creará una imagen de docker con el proyecto y una imagen de SQL Server)

```bash
docker-compose up -d 
```

4. Ingresar a la url para ver documentación de la API

```bash
http://localhost:5000/swagger/index.html
```

