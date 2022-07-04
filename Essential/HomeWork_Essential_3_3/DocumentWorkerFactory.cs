using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_3
{
	class DocumentWorkerFactory
	{
		public DocumentWorker GetDocumentWorker(int key) {

			if (key == 1) {
				return new ProDocumentWorker();
			} else if (key == 2) {
				return new ExpertDocumentWorker();
			} else {
				return new DocumentWorker();
			}
		
		}
	}
}
