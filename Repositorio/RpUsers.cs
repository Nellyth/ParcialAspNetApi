using System;
using System.Collections.Generic;
using System.Linq;
using ParcialAspNetApi.Models;

namespace ParcialAspNetApi.Repositorio
{
	public class RpUsers
	{
		public static List<User> _listUser = new List<User>()
		{
		   new User()
			{
				idUser=1,
				tipoDocumento="CC",
				documento="1044934746",
				nombres="Nellyth J.",
				apellidos="Arroyo Marrugo",
				telefono="3005184942",
				genero="Male",
				direccion="Cartagena de Indias",
				barrio="Los Calamares"
			},
			new User()
			{
				idUser=2,
				tipoDocumento="CC",
				documento="1234567890",
				nombres="Other",
				apellidos="User",
				telefono="3158732176",
				genero="Female",
				direccion="Other direction",
				barrio="other neighorhood"
			}
		};

		public IEnumerable<User> getUsers()
		{
			return _listUser;
		}

		public User getUser(int id)
		{
			var user = _listUser.Where(instance => instance.idUser == id);

			return user.FirstOrDefault();
		}

		public void Agregar(User newUser)
		{
			_listUser.Add(newUser);
		}

		public void DeleteUser(User user)
		{
			_listUser.Remove(user);
		}
	}
}
