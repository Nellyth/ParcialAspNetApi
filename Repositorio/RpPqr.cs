using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcialAspNetApi.Models;
using ParcialAspNetApi.Repositorio;

namespace ParcialAspNetApi.Repositorio
{
	public class RpPqr
	{
		public User getUserOfRepository(int id)
		{
			RpUsers rpUser = new RpUsers();
			return rpUser.getUser(id);
		}

		public static List<PQR> _listPqr = new List<PQR>()
		{
			new PQR()
			{
				idPqr=1,
				grupoDeInteres="Ciudadano",
				pais="Colombia",
				departamento="Bolivar",
				ciudad="Cartagena de Indias",
				correo="nellith25@gmail.com",
				medioDeNotificacionPara="email",
				usuario=new RpUsers().getUser(1),
				asunto="Test",
				descripcion="Problema tecnicos"
			},
			new PQR()
			{
				idPqr=2,
				grupoDeInteres="Empresa",
				pais="1234567890",
				departamento="Other Departament",
				ciudad="Other City",
				correo="asd@mailinator.com",
				medioDeNotificacionPara="email",
				usuario=new RpUsers().getUser(2),
				asunto="Other neighorhood",
				descripcion="Other neighorhood"
			}
		};

		public IEnumerable<PQR> getPqrs()
		{
			return _listPqr;
		}

		public PQR getPqr(int id)
		{
			var pqr = _listPqr.Where(instance => instance.idPqr == id);

			return pqr.FirstOrDefault();
		}

		public void Agregar(PQR newPqr)
		{
			_listPqr.Add(newPqr);
		}

		public void DeletePqr(PQR pqr)
		{
			_listPqr.Remove(pqr);
		}
	}
}
