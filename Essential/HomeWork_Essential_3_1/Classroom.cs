using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_1
{
	class Classroom
	{
		private List<Pupil> _pupils = new List<Pupil>();

		public Classroom (Pupil pupil1, Pupil pupil2){
			_pupils.Add(pupil1);
			_pupils.Add(pupil2);
		}
		public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3): this (pupil1, pupil2) {
			_pupils.Add(pupil3);
		}

		public void Study() {
			foreach (var pupil in _pupils) {
				pupil.Study();
			}
		}
		public void Read() {
			foreach (var pupil in _pupils) {
				pupil.Read();
			}
		}
		public void Write() {
			foreach (var pupil in _pupils) {
				pupil.Write();
			}
		}
		public void Relax() {
			foreach (var pupil in _pupils) {
				pupil.Relax();
			}
		}

		public void AddPupil(Pupil pupil) {
			_pupils.Add(pupil);
		}

	}
}
