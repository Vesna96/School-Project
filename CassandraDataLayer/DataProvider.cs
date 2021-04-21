using Cassandra;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region Predmet
        public static Predmet VratiPredmet(string predmetID)
        {
            ISession session = SessionManager.GetSession();
            Predmet predmet = new Predmet();

            if (session == null)
                return null;

            Row predmetData = session.Execute("select * from \"Predmet\" where \"predmetid\"='" + predmetID + "'").FirstOrDefault();

            if (predmetData != null)
            {
                predmet.predmetID = predmetData["predmetid"] != null ? predmetData["predmetid"].ToString() : string.Empty;
                predmet.nazivPredmeta = predmetData["nazivpredmeta"] != null ? predmetData["nazivpredmeta"].ToString() : string.Empty;

            }

            return predmet;
        }

        public static List<Predmet> VratiPredmete()
        {
            ISession session = SessionManager.GetSession();
            List<Predmet> predmeti = new List<Predmet>();


            if (session == null)
                return null;

            var predmetiData = session.Execute("select * from \"Predmet\"");


            foreach (var predmetData in predmetiData)
            {
                Predmet predmet = new Predmet();
                predmet.predmetID = predmetData["predmetid"] != null ? predmetData["predmetid"].ToString() : string.Empty;
                predmet.nazivPredmeta = predmetData["nazivpredmeta"] != null ? predmetData["nazivpredmeta"].ToString() : string.Empty;
                predmeti.Add(predmet);
            }



            return predmeti;
        }

        public static void DodajPredmet(string predmetID, string naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet predmetData = session.Execute("insert into \"Predmet\" (\"predmetid\", nazivpredmeta)  values ('" + predmetID + "','" + naziv + "')");

        }

        public static void ObrisiPredmet(string predmetID)
        {
            ISession session = SessionManager.GetSession();
            Predmet predmet = new Predmet();

            if (session == null)
                return;

            RowSet predmetData = session.Execute("delete from \"Predmet\" where \"predmetid\" = '" + predmetID + "'");

        }

        public static void AzurirajPredmet(string predmetID, string naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            Predmet p = new Predmet();
            p = VratiPredmet(predmetID);

            RowSet predmetData = session.Execute("update \"Predmet\" set \"nazivpredmeta\" = '" + naziv + "' where \"predmetid\" = '" + predmetID + "'");

        }

        #endregion
        #region Direktor
        public static Direktor GetDirektor(string direktorID)
        {
            ISession session = SessionManager.GetSession();
            Direktor direktor = new Direktor();

            if (session == null)
                return null;

            Row direktorData = session.Execute("select * from \"Direktor\" where \"direktorid\"='" + direktorID + "'").FirstOrDefault();

            if (direktorData != null)
            {
                direktor.direktorID = direktorData["direktorid"] != null ? direktorData["direktorid"].ToString() : string.Empty;
                direktor.imeDirektor = direktorData["imedirektor"] != null ? direktorData["imedirektor"].ToString() : string.Empty;
                direktor.prezimeDirektor = direktorData["prezimedirektor"] != null ? direktorData["prezimedirektor"].ToString() : string.Empty;
            }

            return direktor;
        }
        public static Direktor VratiDirektora()
        {
            ISession session = SessionManager.GetSession();
            Direktor direktor = new Direktor();

            if (session == null)
                return null;

            Row direktorData = session.Execute("select * from \"Direktor\"").FirstOrDefault();

            if (direktorData != null)
            {
                direktor.direktorID = direktorData["direktorid"] != null ? direktorData["direktorid"].ToString() : string.Empty;
                direktor.imeDirektor = direktorData["imedirektor"] != null ? direktorData["imedirektor"].ToString() : string.Empty;
                direktor.prezimeDirektor = direktorData["prezimedirektor"] != null ? direktorData["prezimedirektor"].ToString() : string.Empty;
            }

            return direktor;
        }

        #endregion

        #region Smer
        public static List<Smer> VratiSmerove()
        {
            ISession session = SessionManager.GetSession();
            List<Smer> smerovi = new List<Smer>();


            if (session == null)
                return null;

            var smeroviData = session.Execute("select * from \"Smer\"");


            foreach (var smerData in smeroviData)
            {
                Smer smer = new Smer();
                smer.smerID = smerData["smerid"] != null ? smerData["smerid"].ToString() : string.Empty;
                smer.nazivSmera = smerData["nazivsmera"] != null ? smerData["nazivsmera"].ToString() : string.Empty;
                smerovi.Add(smer);
            }



            return smerovi;
        }

        public static Smer VratiSmer(string smerID)
        {
            ISession session = SessionManager.GetSession();
            Smer smer = new Smer();

            if (session == null)
                return null;

            Row smerData = session.Execute("select * from \"Smer\" where \"smerid\"='" + smerID + "'").FirstOrDefault();

            if (smerData != null)
            {
                smer.smerID = smerData["smerid"] != null ? smerData["smerid"].ToString() : string.Empty;
                smer.nazivSmera = smerData["nazivsmera"] != null ? smerData["nazivsmera"].ToString() : string.Empty;

            }

            return smer;
        }

        public static void DodajSmer(string smerID, string naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet smerData = session.Execute("insert into \"Smer\" (\"smerid\", nazivsmera)  values ('" + smerID + "','" + naziv + "')");

        }

        public static void ObrisiSmer(string smerID)
        {
            ISession session = SessionManager.GetSession();
            Smer smer = new Smer();

            if (session == null)
                return;

            RowSet smerData = session.Execute("delete from \"Smer\" where \"smerid\" = '" + smerID + "'");

        }

        public static void AzurirajSmer(string smerID, string naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            Smer s = new Smer();
            s = VratiSmer(smerID);

            RowSet smerData = session.Execute("update \"Smer\" set \"nazivsmera\" = '" + naziv + "' where \"smerid\" = '" + smerID + "'");

        }

        #endregion
        #region ProfesorNaPredmetu
        

        public static List<ProfesorNaPredmetu> VratiPredmeteZaProfesora()
        {
            ISession session = SessionManager.GetSession();
            List<ProfesorNaPredmetu> pnp = new List<ProfesorNaPredmetu>();


            if (session == null)
                return null;

            var profNaPredmetuData1 = session.Execute("select * from \"ProfesorNaPredmetu\"");


            foreach (var p in profNaPredmetuData1)
            {
                ProfesorNaPredmetu predmet = new ProfesorNaPredmetu();
                predmet.predmetID = p["predmetid"] != null ? p["predmetid"].ToString() : string.Empty;
                predmet.profesorID = p["profesorid"] != null ? p["profesorid"].ToString() : string.Empty;
                predmet.imeProfesor = p["imeprofesor"] != null ? p["imeprofesor"].ToString() : string.Empty;
                predmet.prezimeProfesor = p["prezimeprofesor"] != null ? p["prezimeprofesor"].ToString() : string.Empty;
                predmet.nazivPredmeta = p["nazivpredmeta"] != null ? p["nazivpredmeta"].ToString() : string.Empty;
                pnp.Add(predmet);
            }



            return pnp;
        }

        public static void ObrisiProfesorNaPredmetu(String profID,string predID)
        {
            ISession session = SessionManager.GetSession();
            ProfesorNaPredmetu smer = new ProfesorNaPredmetu();

            if (session == null)
                return;

            RowSet smerData = session.Execute("delete from \"ProfesorNaPredmetu\" where \"profesorid\" = '" + profID + "' and \"predmetid\" = '" + predID + "'");
        }

        public static void DodajProfesoraNaPredmetu(string profesorID, string ime, string prezime, string predmetID, string naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet pnpData = session.Execute("insert into \"ProfesorNaPredmetu\" (\"profesorid\",imeprofesor,prezimeprofesor,\"predmetid\",nazivpredmeta" +
                ")  values ('" + profesorID + "','" + ime + "','" + prezime + "','" + predmetID + "','" + naziv + "')");

        }

        public static List<ProfesorNaPredmetu> VratiProfesoraNaPredmetu(String idProfesora)
        {
            ISession session = SessionManager.GetSession();
            List<ProfesorNaPredmetu> predmeti = new List<ProfesorNaPredmetu>();


            if (session == null)
                return null;

            var predmetiData = session.Execute("select * from \"ProfesorNaPredmetu\" where profesorid = '" + idProfesora + "' allow filtering ");


            foreach (var predmetData in predmetiData)
            {
                ProfesorNaPredmetu pred = new ProfesorNaPredmetu();
                pred.profesorID = predmetData["profesorid"] != null ? predmetData["profesorid"].ToString() : string.Empty;
                pred.imeProfesor = predmetData["imeprofesor"] != null ? predmetData["imeprofesor"].ToString() : string.Empty;
                pred.prezimeProfesor = predmetData["prezimeprofesor"] != null ? predmetData["prezimeprofesor"].ToString() : string.Empty;
                pred.predmetID = predmetData["predmetid"] != null ? predmetData["predmetid"].ToString() : string.Empty;
                pred.nazivPredmeta = predmetData["nazivpredmeta"] != null ? predmetData["nazivpredmeta"].ToString() : string.Empty;
                predmeti.Add(pred);
            }



            return predmeti;
        }
       

        public static List<ProfesorNaPredmetu> VratiProfesoreZaPredmet(String idPredmeta)
        {
            ISession session = SessionManager.GetSession();
            List<ProfesorNaPredmetu> predmeti = new List<ProfesorNaPredmetu>();


            if (session == null)
                return null;

            var predmetiData = session.Execute("select * from \"ProfesorNaPredmetu\" where predmetid = '" + idPredmeta + "' allow filtering ");


            foreach (var predmetData in predmetiData)
            {
                ProfesorNaPredmetu pred = new ProfesorNaPredmetu();
                pred.profesorID = predmetData["profesorid"] != null ? predmetData["profesorid"].ToString() : string.Empty;
                pred.imeProfesor = predmetData["imeprofesor"] != null ? predmetData["imeprofesor"].ToString() : string.Empty;
                pred.prezimeProfesor = predmetData["prezimeprofesor"] != null ? predmetData["prezimeprofesor"].ToString() : string.Empty;
                pred.predmetID = predmetData["predmetid"] != null ? predmetData["predmetid"].ToString() : string.Empty;
                pred.nazivPredmeta = predmetData["nazivpredmeta"] != null ? predmetData["nazivpredmeta"].ToString() : string.Empty;
                predmeti.Add(pred);
            }



            return predmeti;
        }

        public static void ObrisiProfesoraSaPredmeta(string profesorID)
        {
            ISession session = SessionManager.GetSession();


            if (session == null)
                return;
            List<ProfesorNaPredmetu> profesori = DataProvider.VratiProfesoraNaPredmetu(profesorID);

            foreach (ProfesorNaPredmetu prof in profesori)
            {

                RowSet ocData = session.Execute("delete from \"ProfesorNaPredmetu\" where \"profesorid\" = '" + prof.profesorID + "' and \"predmetid\" = '" + prof.predmetID + "'");
            }
        }

        #endregion
        #region OdeljenjeSlusaPredmet
        /*public static OdeljenjeSlusaPredmet VratiOdeljenjeSlusaPredmet(string odSlusaPredID)
        {
            ISession session = SessionManager.GetSession();
            OdeljenjeSlusaPredmet osp = new OdeljenjeSlusaPredmet();

            if (session == null)
                return null;

            Row OdeljenjeSlusaPredmetData = session.Execute("select * from \"ProfesorNaPredmetu\" where \"profesornapredmetuid\"='" + odSlusaPredID + "'").FirstOrDefault();

            if (OdeljenjeSlusaPredmetData != null)
            {
                osp.odeljenjeSlusaPredmetID = OdeljenjeSlusaPredmetData["odeljenjedlusapredmetid"] != null ? OdeljenjeSlusaPredmetData["odeljenjedlusapredmetid"].ToString() : string.Empty;
                osp.predmetID = OdeljenjeSlusaPredmetData["predmetid"] != null ? OdeljenjeSlusaPredmetData["predmetid"].ToString() : string.Empty;
                osp.odeljenjeID = OdeljenjeSlusaPredmetData["odeljenjeid"] != null ? OdeljenjeSlusaPredmetData["odeljenjeid"].ToString() : string.Empty;
                osp.razred = OdeljenjeSlusaPredmetData["razred"] != null ? OdeljenjeSlusaPredmetData["razred"].ToString() : string.Empty;
                osp.nazivPredmeta = OdeljenjeSlusaPredmetData["nazivpredmeta"] != null ? OdeljenjeSlusaPredmetData["nazivpredmeta"].ToString() : string.Empty;

            }

            return osp;
        }*/

        public static List<OdeljenjeSlusaPredmet> VratiOdeljenjaKojaSlusajuPredmete()
        {
            ISession session = SessionManager.GetSession();
            List<OdeljenjeSlusaPredmet> osp = new List<OdeljenjeSlusaPredmet>();


            if (session == null)
                return null;

            var OdeljenjeSlusaPredmetData = session.Execute("select * from \"OdeljenjeSlusaPredmet\"");


            foreach (var p in OdeljenjeSlusaPredmetData)
            {
                OdeljenjeSlusaPredmet odPr = new OdeljenjeSlusaPredmet();
                odPr.predmetID = p["predmetid"] != null ? p["predmetid"].ToString() : string.Empty;
                odPr.odeljenjeID = p["odeljenjeid"] != null ? p["odeljenjeid"].ToString() : string.Empty;
                odPr.nazivPredmeta = p["nazivpredmeta"] != null ? p["nazivpredmeta"].ToString() : string.Empty;
                osp.Add(odPr);
            }



            return osp;
        }

        public static void DodajPredmetZaOdeljenje(string predmetID, string odeljenjeID, string naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet ospData = session.Execute("insert into \"OdeljenjeSlusaPredmet\" (\"predmetid\", odeljenjeid,nazivpredmeta" +
                ")  values ('" + predmetID + "','" + odeljenjeID + "','" + naziv + "')");

        }

        public static List<OdeljenjeSlusaPredmet> VratiPredmeteZaOdeljenje(string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();
            List<OdeljenjeSlusaPredmet> predmeti = new List<OdeljenjeSlusaPredmet>();


            if (session == null)
                return null;

            var predmetiData = session.Execute("select * from \"OdeljenjeSlusaPredmet\"");


            foreach (var predData in predmetiData)
            {
                if (odeljenjeID.Equals(predData["odeljenjeid"]))
                {
                    OdeljenjeSlusaPredmet predmet = new OdeljenjeSlusaPredmet();
                    predmet.predmetID = predData["predmetid"] != null ? predData["predmetid"].ToString() : string.Empty;
                    predmet.nazivPredmeta = predData["nazivpredmeta"] != null ? predData["nazivpredmeta"].ToString() : string.Empty;
                    predmet.odeljenjeID = predData["odeljenjeid"] != null ? predData["odeljenjeid"].ToString() : string.Empty;

                    predmeti.Add(predmet);
                }

            }



            return predmeti;
        }

        public static void ObrisiPredmetZaOdeljenje(string predmetID, string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();
            OdeljenjeSlusaPredmet osp = new OdeljenjeSlusaPredmet();

            if (session == null)
                return;

            RowSet ospData = session.Execute("delete from \"OdeljenjeSlusaPredmet\" where \"predmetid\" = '" + predmetID +
                "' and \"odeljenjeid\" = '" + odeljenjeID + "'");

        }

        #endregion
        #region Ucenik
        public static Ucenik VratiUcenika(string ucenikId)
        {
            ISession session = SessionManager.GetSession();
            Ucenik ucenik = new Ucenik();

            if (session == null)
                return null;

            Row ucenikData = session.Execute("select * from \"Ucenik\" where \"ucenikid\"='" + ucenikId + "'").FirstOrDefault();

            if (ucenikData != null)
            {
                ucenik.ucenikID = ucenikData["ucenikid"] != null ? ucenikData["ucenikid"].ToString() : string.Empty;
                ucenik.imeUcenik = ucenikData["imeucenik"] != null ? ucenikData["imeucenik"].ToString() : string.Empty;
                ucenik.odeljenjeID = ucenikData["odeljenjeid"] != null ? ucenikData["odeljenjeid"].ToString() : string.Empty;
                ucenik.prezimeUcenik = ucenikData["prezimeucenik"] != null ? ucenikData["prezimeucenik"].ToString() : string.Empty;
               

            }

            return ucenik;
        }


        public static List<Ucenik> VratiUcenike()
        {
            ISession session = SessionManager.GetSession();
            List<Ucenik> ucenici = new List<Ucenik>();


            if (session == null)
                return null;

            var uceniciData = session.Execute("select * from \"Ucenik\"");


            foreach (var u in uceniciData)
            {
                Ucenik uc = new Ucenik();
                uc.ucenikID = u["ucenikid"] != null ? u["ucenikid"].ToString() : string.Empty;
                uc.imeUcenik = u["imeucenik"] != null ? u["imeucenik"].ToString() : string.Empty;
                uc.odeljenjeID = u["odeljenjeid"] != null ? u["odeljenjeid"].ToString() : string.Empty;
                uc.prezimeUcenik = u["prezimeucenik"] != null ? u["prezimeucenik"].ToString() : string.Empty;
                ucenici.Add(uc);
            }



            return ucenici;
        }

        public static List<Ucenik> VratiUcenikeIzOdeljenja(string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();
            List<Ucenik> ucenici = new List<Ucenik>();


            if (session == null)
                return null;

            var uceniciData = session.Execute("select * from \"Ucenik\"");


            foreach (var ucenikData in uceniciData)
            {
                if (odeljenjeID.Equals(ucenikData["odeljenjeid"]))
                {
                    Ucenik ucenik = new Ucenik();
                    ucenik.ucenikID = ucenikData["ucenikid"] != null ? ucenikData["ucenikid"].ToString() : string.Empty;
                    ucenik.imeUcenik = ucenikData["imeucenik"] != null ? ucenikData["imeucenik"].ToString() : string.Empty;
                    ucenik.prezimeUcenik = ucenikData["prezimeucenik"] != null ? ucenikData["prezimeucenik"].ToString() : string.Empty;
                    ucenik.odeljenjeID = ucenikData["odeljenjeid"] != null ? ucenikData["odeljenjeid"].ToString() : string.Empty;
                    ucenici.Add(ucenik);
                }

            }



            return ucenici;
        }

        public static void DodajUcenika(string ucenikID, string ime, string prezime, string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet ucenikData = session.Execute("insert into \"Ucenik\" (\"ucenikid\", imeucenik,prezimeucenik,odeljenjeID" +
                ")  values ('" + ucenikID + "','" + ime + "','" + prezime + "','" + odeljenjeID + "')");

        }
        public static void ObrisiUcenika(string ucenikID)
        {
            ISession session = SessionManager.GetSession();
            Ucenik ucenik = new Ucenik();

            if (session == null)
                return;

            RowSet ucenikData = session.Execute("delete from \"Ucenik\" where \"ucenikid\" = '" + ucenikID + "'");

        }

        public static void PremestiUcenikaUDrugoOdeljenje(string ucenikID, string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet ucenikData = session.Execute("update \"Ucenik\" set \"odeljenjeid\" = '" + odeljenjeID +
                "' where \"ucenikid\" = '" + ucenikID + "'");

        }

        #endregion
        #region Cas
        public static Cas VratiCas(string casID)
        {
            ISession session = SessionManager.GetSession();
            Cas cas = new Cas();

            if (session == null)
                return null;

            Row casData = session.Execute("select * from \"Cas\" where \"casid\"='" + casID + "'").FirstOrDefault();

            if (casData != null)
            {
                cas.casID = casData["casid"] != null ? casData["casid"].ToString() : string.Empty;
                cas.datumCas = casData["datumcas"] != null ? casData["datumcas"].ToString() : string.Empty;
                cas.opisCas = casData["opiscas"] != null ? casData["opiscas"].ToString() : string.Empty;
                cas.imeProfesor = casData["imeprofesor"] != null ? casData["imeprofesor"].ToString() : string.Empty;
                cas.odeljenjeID = casData["odeljenjeid"] != null ? casData["odeljenjeid"].ToString() : string.Empty;
                cas.prezimeProfesor = casData["prezimeprofesor"] != null ? casData["prezimeprofesor"].ToString() : string.Empty;
                cas.profesorID = casData["profesorid"] != null ? casData["profesorid"].ToString() : string.Empty;
                cas.napomena = casData["napomena"] != null ? casData["napomena"].ToString() : string.Empty;

            }

            return cas;
        }


        public static List<Cas> VratiCasove()
        {
            ISession session = SessionManager.GetSession();
            List<Cas> casovi = new List<Cas>();


            if (session == null)
                return null;

            var casoviData = session.Execute("select * from \"Cas\"");


            foreach (var cas in casoviData)
            {
                Cas c = new Cas();
                c.casID = cas["casid"] != null ? cas["casid"].ToString() : string.Empty;
                c.datumCas = cas["datumcas"] != null ? cas["datumcas"].ToString() : string.Empty;
                c.opisCas = cas["opiscas"] != null ? cas["opiscas"].ToString() : string.Empty;
                c.imeProfesor = cas["imeprofesor"] != null ? cas["imeprofesor"].ToString() : string.Empty;
                c.odeljenjeID = cas["odeljenjeid"] != null ? cas["odeljenjeid"].ToString() : string.Empty;
                c.prezimeProfesor = cas["prezimeprofesor"] != null ? cas["prezimeprofesor"].ToString() : string.Empty;
                c.profesorID = cas["profesorid"] != null ? cas["profesorid"].ToString() : string.Empty;
                c.napomena = cas["napomena"] != null ? cas["napomena"].ToString() : string.Empty;
                casovi.Add(c);
            }



            return casovi;
        }

        public static void DodajCas(string casID,string datum, string opis,string profesorID, string imeProfesor,string prezimeProfesor, string odeljenjeID, string napomena)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet casData = session.Execute("insert into \"Cas\" (\"casid\", datumcas, opiscas, profesorid, imeprofesor, prezimeprofesor, odeljenjeid, napomena)  values ('" + casID + "','" + datum + "','" + opis + "','" + profesorID + "','" + imeProfesor + "','" + prezimeProfesor + "','" + odeljenjeID + "','" + napomena +"')");

        }

        public static List<Cas> VratiCasove(string id_odeljenja)
        {
            ISession session = SessionManager.GetSession();
            List<Cas> casovi = new List<Cas>();


            if (session == null)
                return null;

            var casoviData = session.Execute("select * from \"Cas\"");


            foreach (var cas in casoviData)
            {
                if(cas["odeljenjeid"].Equals(id_odeljenja) && !(cas["napomena"].Equals(string.Empty)))
                {
                    Cas c = new Cas();
                    c.casID = cas["casid"] != null ? cas["casid"].ToString() : string.Empty;
                    c.datumCas = cas["datumcas"] != null ? cas["datumcas"].ToString() : string.Empty;
                    c.opisCas = cas["opiscas"] != null ? cas["opiscas"].ToString() : string.Empty;
                    c.imeProfesor = cas["imeprofesor"] != null ? cas["imeprofesor"].ToString() : string.Empty;
                    c.odeljenjeID = cas["odeljenjeid"] != null ? cas["odeljenjeid"].ToString() : string.Empty;
                    c.prezimeProfesor = cas["prezimeprofesor"] != null ? cas["prezimeprofesor"].ToString() : string.Empty;
                    c.profesorID = cas["profesorid"] != null ? cas["profesorid"].ToString() : string.Empty;
                    c.napomena = cas["napomena"] != null ? cas["napomena"].ToString() : string.Empty;
                    casovi.Add(c);
                }
            }



            return casovi;
        }

        #endregion
        #region Profesor
        /*public static Predmet VratiPredmet(string predmetID)
        {
            ISession session = SessionManager.GetSession();
            Predmet predmet = new Predmet();

            if (session == null)
                return null;

            Row predmetData = session.Execute("select * from \"Predmet\" where \"predmetid\"='" + predmetID + "'").FirstOrDefault();

            if (predmetData != null)
            {
                predmet.predmetID = predmetData["predmetid"] != null ? predmetData["predmetid"].ToString() : string.Empty;
                predmet.nazivPredmeta = predmetData["nazivpredmeta"] != null ? predmetData["nazivpredmeta"].ToString() : string.Empty;

            }

            return predmet;
        }*/

        public static List<Profesor> VratiProfesore()
        {
            ISession session = SessionManager.GetSession();
            List<Profesor> profesori = new List<Profesor>();


            if (session == null)
                return null;

            var profesoriData = session.Execute("select * from \"Profesor\"");


            foreach (var p in profesoriData)
            {
                Profesor prof = new Profesor();
                prof.profesorID = p["profesorid"] != null ? p["profesorid"].ToString() : string.Empty;
                prof.imeProfesor = p["imeprofesor"] != null ? p["imeprofesor"].ToString() : string.Empty;
                prof.prezimeProfesor = p["prezimeprofesor"] != null ? p["prezimeprofesor"].ToString() : string.Empty;
                profesori.Add(prof);
            }



            return profesori;
        }

        public static Profesor VratiProfesora(string profesorID)
        {
            ISession session = SessionManager.GetSession();
            Profesor profesor = new Profesor();

            if (session == null)
                return null;

            Row profesorData = session.Execute("select * from \"Profesor\" where \"profesorid\"='" + profesorID + "'").FirstOrDefault();

            if (profesorData != null)
            {
                profesor.profesorID = profesorData["profesorid"] != null ? profesorData["profesorid"].ToString() : string.Empty;
                profesor.imeProfesor = profesorData["imeprofesor"] != null ? profesorData["imeprofesor"].ToString() : string.Empty;
                profesor.prezimeProfesor = profesorData["prezimeprofesor"] != null ? profesorData["prezimeprofesor"].ToString() : string.Empty;
            }

            return profesor;
        }

        public static void DodajProfesora(string profesorID, string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet profesorData = session.Execute("insert into \"Profesor\" (\"profesorid\", imeprofesor,prezimeprofesor" +
                ")  values ('" + profesorID + "','" + ime + "','" + prezime + "')");

        }
        public static void ObrisiProfesora(string profID)
        {
            ISession session = SessionManager.GetSession();
            Profesor prof = new Profesor();

            if (session == null)
                return;

            RowSet profData = session.Execute("delete from \"Profesor\" where \"profesorid\" = '" + profID + "'");

        }

        #endregion
        #region Ocene
        public static Ocene VratiOcenu(string predmetID,string ucenikID)
        {
            ISession session = SessionManager.GetSession();
            Ocene ocena = new Ocene();

            if (session == null)
                return null;

            Row ocenaData = session.Execute("select * from \"Ocene\" where \"predmetid\"='" + predmetID +"' and \"ucenikid\"='" + ucenikID + "' allow filtering").FirstOrDefault();

            if (ocenaData != null)
            {
                
                ocena.imeUcenik = ocenaData["imeucenik"] != null ? ocenaData["imeucenik"].ToString() : string.Empty;
                ocena.prezimeUcenik = ocenaData["prezimeucenik"] != null ? ocenaData["prezimeucenik"].ToString() : string.Empty;
                ocena.prosek = ocenaData["prosek"] != null ? ocenaData["prosek"].ToString() : string.Empty;
                ocena.test1 = ocenaData["test1"] != null ? ocenaData["test1"].ToString() : string.Empty;
                ocena.test2 = ocenaData["test2"] != null ? ocenaData["test2"].ToString() : string.Empty;
                ocena.test3 = ocenaData["test3"] != null ? ocenaData["test3"].ToString() : string.Empty;
                ocena.test4 = ocenaData["test4"] != null ? ocenaData["test4"].ToString() : string.Empty;
                ocena.ucenikID = ocenaData["ucenikid"] != null ? ocenaData["ucenikid"].ToString() : string.Empty;
                ocena.predmetID = ocenaData["predmetid"] != null ? ocenaData["predmetid"].ToString() : string.Empty;
                //ocena.odeljenjeID = ocenaData["odeljenjeid"] != null ? ocenaData["odeljenjeid"].ToString() : string.Empty;
                ocena.zakljucnaOcena = ocenaData["zakljucnaocena"] != null ? ocenaData["zakljucnaocena"].ToString() : string.Empty;


            }

            return ocena;
        }

        

        public static void ObrisiOceneZaUcenika(string ucenikID)
        {
            ISession session = SessionManager.GetSession();
            
            
            if (session == null)
                return;
            List<Ocene> ocene = DataProvider.VratiOceneZaUcenika(ucenikID);

            foreach (Ocene oc in ocene)
            {
                string pred = oc.predmetID;
                RowSet ocData = session.Execute("delete from \"Ocene\" where \"ucenikid\" = '" + oc.ucenikID + "' and \"predmetid\" = '" +oc.predmetID +"'");
            }
        }

        public static List<Ocene> VratiOceneZaUcenika(string ucenikID)
        {
            ISession session = SessionManager.GetSession();
            List<Ocene> ocene = new List<Ocene>();


            if (session == null)
                return null;


            var oceneData = session.Execute("select * from \"Ocene\" where \"ucenikid\"='" + ucenikID + "' allow filtering");


            foreach (var ocena in oceneData)
            {
                Ocene oc = new Ocene();
                oc.ucenikID = ocena["ucenikid"] != null ? ocena["ucenikid"].ToString() : string.Empty;
                oc.predmetID = ocena["predmetid"] != null ? ocena["predmetid"].ToString() : string.Empty;
                oc.imeUcenik = ocena["imeucenik"] != null ? ocena["imeucenik"].ToString() : string.Empty;
                oc.prezimeUcenik = ocena["prezimeucenik"] != null ? ocena["prezimeucenik"].ToString() : string.Empty;
                oc.prosek = ocena["prosek"] != null ? ocena["prosek"].ToString() : string.Empty;
                oc.test1 = ocena["test1"] != null ? ocena["test1"].ToString() : string.Empty;
                oc.test2 = ocena["test2"] != null ? ocena["test2"].ToString() : string.Empty;
                oc.test3 = ocena["test3"] != null ? ocena["test3"].ToString() : string.Empty;
                oc.test4 = ocena["test4"] != null ? ocena["test4"].ToString() : string.Empty;
                
                oc.zakljucnaOcena = ocena["zakljucnaocena"] != null ? ocena["zakljucnaocena"].ToString() : string.Empty;
                ocene.Add(oc);
            }



            return ocene;
        }

        public static void AzurirajOcene(string predmetID, string ucenikID,string ime,string prezime,string test1,string test2,string test3,string test4,string prosek,string zakljucnaOcena)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet smerData = session.Execute("update \"Ocene\" set \"imeucenik\" = '" + ime + "'," + "\"prezimeucenik\" = '" + prezime + "'," + "\"test1\" = '" + test1 + "'," + "\"test2\" = '" + test2 + "',"+" \"test3\" = '" + test3 + "',"+"\"test4\" = '" + test4 + "'," + "\"prosek\" = '" + prosek + "'," + "\"zakljucnaocena\" = '" + zakljucnaOcena + "' where \"predmetid\" = '" + predmetID + "' and \"ucenikid\" = '" + ucenikID+ "'");

        }


        public static void DodajOcenu(string predmetID,string ucenikID, string ime,string prezime,string test1, string test2, string test3, string test4, string prosek, string zakljucnaOcena)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet ocenaData = session.Execute("insert into \"Ocene\" (\"predmetid\",\"ucenikid\" ,imeucenik, prezimeucenik, test1, test2, test3, test4,prosek,zakljucnaocena)  values ('" + predmetID + "','" + ucenikID  + "','" + ime+ "','" + prezime + "','" + test1 + "','" + test2 + "','" + test3 + "','" + test4 + "','" + prosek + "','" + zakljucnaOcena  + "')");

        }

        

        #endregion
        
        #region Izostanak
        public static Izostanak VratiIzostanak(string casID, string ucenikID)
        {
            ISession session = SessionManager.GetSession();
            Izostanak izostanak = new Izostanak();

            if (session == null)
                return null;

            Row izostanakData = session.Execute("select * from \"Izostanak\"where \"casid\" = '" + casID +
                "' and \"ucenikid\" = '" + ucenikID + "'").FirstOrDefault();

            if (izostanakData != null)
            {
                //izostanak.izostanakID = izostanakData["izostanakid"] != null ? izostanakData["izostanakid"].ToString() : string.Empty;
                izostanak.casID = izostanakData["casid"] != null ? izostanakData["casid"].ToString() : string.Empty;
                izostanak.datumIzostanak = izostanakData["datumizostanak"] != null ? izostanakData["datumizostanak"].ToString() : string.Empty;
                izostanak.imeUcenik = izostanakData["imeucenik"] != null ? izostanakData["imeucenik"].ToString() : string.Empty;
                izostanak.odeljenjeID = izostanakData["odeljenjeid"] != null ? izostanakData["odeljenjeid"].ToString() : string.Empty;
                izostanak.prezimeUcenik = izostanakData["prezimeucenik"] != null ? izostanakData["prezimeucenik"].ToString() : string.Empty;
                izostanak.tip = izostanakData["tip"] != null ? izostanakData["tip"].ToString() : string.Empty;
                izostanak.ucenikID = izostanakData["ucenikid"] != null ? izostanakData["ucenikid"].ToString() : string.Empty;
                

            }

            return izostanak;
        }

        public static List<Izostanak> VratiIzostanke()
        {
            ISession session = SessionManager.GetSession();
            List<Izostanak> izostanci = new List<Izostanak>();


            if (session == null)
                return null;

            var izostanciData = session.Execute("select * from \"Izostanak\"");


            foreach (var izostanakData in izostanciData)
            {
                Izostanak izostanak = new Izostanak();
                //izostanak.izostanakID = izostanakData["izostanakid"] != null ? izostanakData["izostanakid"].ToString() : string.Empty;
                izostanak.casID = izostanakData["casid"] != null ? izostanakData["casid"].ToString() : string.Empty;
                izostanak.datumIzostanak = izostanakData["datumIzostanak"] != null ? izostanakData["datumIzostanak"].ToString() : string.Empty;
                izostanak.imeUcenik = izostanakData["imeucenik"] != null ? izostanakData["imeucenik"].ToString() : string.Empty;
                izostanak.odeljenjeID = izostanakData["odeljenjeid"] != null ? izostanakData["odeljenjeid"].ToString() : string.Empty;
                izostanak.prezimeUcenik = izostanakData["prezimeucenik"] != null ? izostanakData["prezimeucenik"].ToString() : string.Empty;
                izostanak.tip = izostanakData["tip"] != null ? izostanakData["tip"].ToString() : string.Empty;
                izostanak.ucenikID = izostanakData["ucenikid"] != null ? izostanakData["ucenikid"].ToString() : string.Empty;
                izostanci.Add(izostanak);
            }



            return izostanci;
        }

        public static void DodajIzostanak(string casid, string datumizostanak, string ime, string odeljenjeID,string prez, string tip, string ucenikid)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet napomenaData = session.Execute("insert into \"Izostanak\" (\"casid\", datumizostanak, imeucenik, odeljenjeid,prezimeucenik,tip, \"ucenikid\")  values ('" + casid +  "','" + datumizostanak + "','" + ime + "','" + odeljenjeID + "','" + prez + "','" + tip + "','" + ucenikid + "')");

        }

        public static List<Izostanak> VratiIzostankeIzOdeljenja(string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();
            List<Izostanak> izostanci = new List<Izostanak>();


            if (session == null)
                return null;

            var izostanciData = session.Execute("select * from \"Izostanak\" where \"odeljenjeid\" = '"+ odeljenjeID + "' allow filtering");

            


            foreach (var izostanakData in izostanciData)
            {
                
                    Izostanak izostanak = new Izostanak();
                    //izostanak.izostanakID = izostanakData["izostanakid"] != null ? izostanakData["izostanakid"].ToString() : string.Empty;
                    izostanak.casID = izostanakData["casid"] != null ? izostanakData["casid"].ToString() : string.Empty;
                    izostanak.datumIzostanak = izostanakData["datumizostanak"] != null ? izostanakData["datumizostanak"].ToString() : string.Empty;
                    izostanak.odeljenjeID = izostanakData["odeljenjeid"] != null ? izostanakData["odeljenjeid"].ToString() : string.Empty;
                    izostanak.imeUcenik = izostanakData["imeucenik"] != null ? izostanakData["imeucenik"].ToString() : string.Empty;
                    izostanak.prezimeUcenik = izostanakData["prezimeucenik"] != null ? izostanakData["prezimeucenik"].ToString() : string.Empty;
                    izostanak.tip = izostanakData["tip"] != null ? izostanakData["tip"].ToString() : string.Empty;
                    izostanak.ucenikID = izostanakData["ucenikid"] != null ? izostanakData["ucenikid"].ToString() : string.Empty;
                    izostanci.Add(izostanak);
                

            }



            return izostanci;
        }

        public static void AzurirajIzostanak(string casID,string ucenikID, string tip)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            Izostanak izostanak = new Izostanak();
            izostanak = VratiIzostanak(casID,ucenikID);

            RowSet izostanakData = session.Execute("update \"Izostanak\" set \"tip\" = '" + tip + "' where \"casid\" = '" + casID +
                "' and \"ucenikid\" = '" + ucenikID + "'");

        }

        /*public static void ObrisiIzostanak(string izostanakID)
        {
            ISession session = SessionManager.GetSession();
            Izostanak izostanak = new Izostanak();

            if (session == null)
                return;

            RowSet izostanakData = session.Execute("delete from \"Izostanak\" where \"izostanakid\" = '" + izostanakID + "'");

        }*/

        public static void ObrisiIzostankeZaUcenika(string ucenikID)
        {
            ISession session = SessionManager.GetSession();


            if (session == null)
                return;
            List<Izostanak> izostanci = DataProvider.VratiIzostankeZaUcenika(ucenikID);

            foreach (Izostanak izo in izostanci)
            {
                
                RowSet ocData = session.Execute("delete from \"Izostanak\" where \"ucenikid\" = '" + izo.ucenikID + "' and \"casid\" = '" + izo.casID + "'");
            }
        }

        public static List<Izostanak> VratiIzostankeZaUcenika(string ucenikID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            List<Izostanak> izostanci = new List<Izostanak>();
            var izostanciData = session.Execute("select * from \"Izostanak\" where \"ucenikid\"='" + ucenikID + "' allow filtering");


            foreach (var izostanak in izostanciData)
            {
                Izostanak izo = new Izostanak();
                izo.ucenikID = izostanak["ucenikid"] != null ? izostanak["ucenikid"].ToString() : string.Empty;
                izo.casID = izostanak["casid"] != null ? izostanak["casid"].ToString() : string.Empty;
                izo.imeUcenik = izostanak["imeucenik"] != null ? izostanak["imeucenik"].ToString() : string.Empty;
                izo.prezimeUcenik = izostanak["prezimeucenik"] != null ? izostanak["prezimeucenik"].ToString() : string.Empty;
                izo.odeljenjeID = izostanak["odeljenjeid"] != null ? izostanak["odeljenjeid"].ToString() : string.Empty;
                izo.datumIzostanak = izostanak["datumizostanak"] != null ? izostanak["datumizostanak"].ToString() : string.Empty;
                izo.tip = izostanak["tip"] != null ? izostanak["tip"].ToString() : string.Empty;
                
                izostanci.Add(izo);
            }



            return izostanci;
        }


        #endregion

        #region Odeljenje
        public static Odeljenje VratiOdeljenjeProfesor(string profesorID)
        {
            ISession session = SessionManager.GetSession();
            Odeljenje odeljenje = new Odeljenje();

            if (session == null)
                return null;

            var odeljenjaData = session.Execute("select * from \"Odeljenje\"");
            foreach(var odeljenjeData in odeljenjaData)
            {
                if(odeljenjeData["profesorid"].Equals(profesorID))
                {
                    odeljenje.odeljenjeID = odeljenjeData["odeljenjeid"] != null ? odeljenjeData["odeljenjeid"].ToString() : string.Empty;
                    odeljenje.profesorID = odeljenjeData["profesorid"] != null ? odeljenjeData["profesorid"].ToString() : string.Empty;
                    odeljenje.razredniIme = odeljenjeData["razredniime"] != null ? odeljenjeData["razredniime"].ToString() : string.Empty;
                    odeljenje.razredniPrezime = odeljenjeData["razredniprezime"] != null ? odeljenjeData["razredniprezime"].ToString() : string.Empty;
                    odeljenje.smerID = odeljenjeData["smerid"] != null ? odeljenjeData["smerid"].ToString() : string.Empty;
                }
            }

            return odeljenje;
        }

        public static List<Odeljenje> VratiOdeljenja()
        {
            ISession session = SessionManager.GetSession();
            List<Odeljenje> odeljenja = new List<Odeljenje>();


            if (session == null)
                return null;

            var odeljenjaData = session.Execute("select * from \"Odeljenje\"");


            foreach (var odData in odeljenjaData)
            {
                Odeljenje odeljenje = new Odeljenje();
                odeljenje.odeljenjeID = odData["odeljenjeid"] != null ? odData["odeljenjeid"].ToString() : string.Empty;
                odeljenje.profesorID = odData["profesorid"] != null ? odData["profesorid"].ToString() : string.Empty;
                odeljenje.razredniIme = odData["razredniime"] != null ? odData["razredniime"].ToString() : string.Empty;
                odeljenje.razredniPrezime = odData["razredniprezime"] != null ? odData["razredniprezime"].ToString() : string.Empty;
                odeljenje.smerID = odData["smerid"] != null ? odData["smerid"].ToString() : string.Empty;
                odeljenja.Add(odeljenje);
            }



            return odeljenja;
        }

        public static List<Odeljenje> VratiOdeljenjaSaSmera(string smerID)
        {
            ISession session = SessionManager.GetSession();
            List<Odeljenje> odeljenja = new List<Odeljenje>();


            if (session == null)
                return null;

            var odeljenjaData = session.Execute("select * from \"Odeljenje\"");


            foreach (var odeljenjeData in odeljenjaData)
            {
                if (smerID.Equals(odeljenjeData["smerid"]))
                {
                    Odeljenje od = new Odeljenje();
                    od.odeljenjeID = odeljenjeData["odeljenjeid"] != null ? odeljenjeData["odeljenjeid"].ToString() : string.Empty;
                    //od.razred = odeljenjeData["razred"] != null ? odeljenjeData["razred"].ToString() : string.Empty;

                    od.profesorID = odeljenjeData["profesorid"] != null ? odeljenjeData["profesorid"].ToString() : string.Empty;
                    od.razredniIme = odeljenjeData["razredniime"] != null ? odeljenjeData["razredniime"].ToString() : string.Empty;
                    od.razredniPrezime = odeljenjeData["razredniprezime"] != null ? odeljenjeData["razredniprezime"].ToString() : string.Empty;
                    od.smerID = odeljenjeData["smerid"] != null ? odeljenjeData["smerid"].ToString() : string.Empty;
                    odeljenja.Add(od);
                }

            }
            return odeljenja;
        }

        public static void DodajOdeljenje(string odeljenjeID, string smerID, string profesorID, string razredniIme, string razredniPrezime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet smerData = session.Execute("insert into \"Odeljenje\" (\"odeljenjeid\", \"smerid\",profesorid,razredniime,razredniprezime" +
                ")  values ('" + odeljenjeID + "','" + smerID + "','" + profesorID + "','" + razredniIme +
                "','" + razredniPrezime + "')");

        }

        public static void ObrisiOdeljenje(string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();
            Odeljenje od = new Odeljenje();

            if (session == null)
                return;

            RowSet odeljenjeData = session.Execute("delete from \"Odeljenje\" where \"odeljenjeid\" = '" + odeljenjeID + "'");

        }

        public static Odeljenje VratiOdeljenje(string odeljenjeID)
        {
            ISession session = SessionManager.GetSession();
            Odeljenje od = new Odeljenje();

            if (session == null)
                return null;

            Row odeljenjeData = session.Execute("select * from \"Odeljenje\" where \"odeljenjeid\"='" + odeljenjeID + "'").FirstOrDefault();

            if (odeljenjeData != null)
            {
                od.odeljenjeID = odeljenjeData["odeljenjeid"] != null ? odeljenjeData["odeljenjeid"].ToString() : string.Empty;
                //od.razred = odeljenjeData["razred"] != null ? odeljenjeData["razred"].ToString() : string.Empty;
                od.profesorID = odeljenjeData["profesorid"] != null ? odeljenjeData["profesorid"].ToString() : string.Empty;
                od.razredniIme = odeljenjeData["razredniime"] != null ? odeljenjeData["razredniime"].ToString() : string.Empty;
                od.razredniPrezime = odeljenjeData["razredniprezime"] != null ? odeljenjeData["razredniprezime"].ToString() : string.Empty;
                od.smerID = odeljenjeData["smerid"] != null ? odeljenjeData["smerid"].ToString() : string.Empty;
            }

            return od;
        }

        public static void PromeniRazrednog(string odeljenjeID, string profesorID, string razredniIme, string razredniPrezime, string smerID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            /*Odeljenje od = new Odeljenje();
            od = VratiOdeljenje(odeljenjeID*/

            RowSet odeljenjeData = session.Execute("update \"Odeljenje\" set \"profesorid\" = '" + profesorID +
                "', \"razredniime\" = '" + razredniIme + "', \"razredniprezime\" = '" + razredniPrezime +
                
                " 'where \"odeljenjeid\" = '" + odeljenjeID + "' and \"smerid\" = '" + smerID + "'");

        }

        #endregion

        #region ProfesorPredmetOdeljenje
        public static List<ProfesorPredmetOdeljenje> VratiProfesorPredmetOdeljenje(String idProfesora)
        {
            ISession session = SessionManager.GetSession();
            List<ProfesorPredmetOdeljenje> odeljenja = new List<ProfesorPredmetOdeljenje>();


            if (session == null)
                return null;

            var odeljenjaData = session.Execute("select * from \"ProfesorPredmetOdeljenje\" where profesorid = '" + idProfesora + "' allow filtering");


            foreach (var odeljenjeData in odeljenjaData)
            {
                ProfesorPredmetOdeljenje ode = new ProfesorPredmetOdeljenje();
                ode.profesorID = odeljenjeData["profesorid"] != null ? odeljenjeData["profesorid"].ToString() : string.Empty;
                ode.imeProfesor = odeljenjeData["imeprofesor"] != null ? odeljenjeData["imeprofesor"].ToString() : string.Empty;
                ode.prezimeProfesor = odeljenjeData["prezimeprofesor"] != null ? odeljenjeData["prezimeprofesor"].ToString() : string.Empty;
                ode.predmetID = odeljenjeData["predmetid"] != null ? odeljenjeData["predmetid"].ToString() : string.Empty;
                ode.nazivPredmeta = odeljenjeData["nazivpredmeta"] != null ? odeljenjeData["nazivpredmeta"].ToString() : string.Empty;
                ode.odeljenjeId = odeljenjeData["odeljenjeid"] != null ? odeljenjeData["odeljenjeid"].ToString() : string.Empty;
                odeljenja.Add(ode);
            }



            return odeljenja;
        }

        public static List<ProfesorPredmetOdeljenje> VratiOdeljenjeZaPredmetProfesor(String idProfesora,string idPredmet)
        {
            ISession session = SessionManager.GetSession();
            List<ProfesorPredmetOdeljenje> odeljenja = new List<ProfesorPredmetOdeljenje>();


            if (session == null)
                return null;

            var odeljenjaData = session.Execute("select * from \"ProfesorPredmetOdeljenje\" where profesorid = '" + idProfesora + "' and predmetid = '" + idPredmet +"' allow filtering");


            foreach (var odeljenjeData in odeljenjaData)
            {
                ProfesorPredmetOdeljenje ode = new ProfesorPredmetOdeljenje();
                ode.profesorID = odeljenjeData["profesorid"] != null ? odeljenjeData["profesorid"].ToString() : string.Empty;
                ode.imeProfesor = odeljenjeData["imeprofesor"] != null ? odeljenjeData["imeprofesor"].ToString() : string.Empty;
                ode.prezimeProfesor = odeljenjeData["prezimeprofesor"] != null ? odeljenjeData["prezimeprofesor"].ToString() : string.Empty;
                ode.predmetID = odeljenjeData["predmetid"] != null ? odeljenjeData["predmetid"].ToString() : string.Empty;
                ode.nazivPredmeta = odeljenjeData["nazivpredmeta"] != null ? odeljenjeData["nazivpredmeta"].ToString() : string.Empty;
                ode.odeljenjeId = odeljenjeData["odeljenjeid"] != null ? odeljenjeData["odeljenjeid"].ToString() : string.Empty;
                odeljenja.Add(ode);
            }



            return odeljenja;
        }
        public static List<ProfesorPredmetOdeljenje> VratiProfesorPredmetZaOdeljenje(String idOdeljenja)
        {
            ISession session = SessionManager.GetSession();
            List<ProfesorPredmetOdeljenje> odeljenja = new List<ProfesorPredmetOdeljenje>();


            if (session == null)
                return null;

            var odeljenjaData = session.Execute("select * from \"ProfesorPredmetOdeljenje\" where odeljenjeid = '" + idOdeljenja + "' allow filtering");


            foreach (var odeljenjeData in odeljenjaData)
            {
                ProfesorPredmetOdeljenje ode = new ProfesorPredmetOdeljenje();
                ode.profesorID = odeljenjeData["profesorid"] != null ? odeljenjeData["profesorid"].ToString() : string.Empty;
                ode.imeProfesor = odeljenjeData["imeprofesor"] != null ? odeljenjeData["imeprofesor"].ToString() : string.Empty;
                ode.prezimeProfesor = odeljenjeData["prezimeprofesor"] != null ? odeljenjeData["prezimeprofesor"].ToString() : string.Empty;
                ode.predmetID = odeljenjeData["predmetid"] != null ? odeljenjeData["predmetid"].ToString() : string.Empty;
                ode.nazivPredmeta = odeljenjeData["nazivpredmeta"] != null ? odeljenjeData["nazivpredmeta"].ToString() : string.Empty;
                ode.odeljenjeId = odeljenjeData["odeljenjeid"] != null ? odeljenjeData["odeljenjeid"].ToString() : string.Empty;
                odeljenja.Add(ode);
            }



            return odeljenja;
        }
        public static void DodajProfesoraPredmetOdeljenje(string profesorID, string ime, string prezime, string predmetID, string odeljenjeID,string naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet pnpData = session.Execute("insert into \"ProfesorPredmetOdeljenje\" (\"profesorid\",imeprofesor,prezimeprofesor,\"predmetid\",nazivpredmeta,\"odeljenjeid\"" +
                ")  values ('" + profesorID + "','" + ime + "','" + prezime + "','" + predmetID + "','" + naziv + "','"+ odeljenjeID + "')");

        }


        public static void ObrisiProfesoraPredmetOdeljenje(string profesorID)
        {
            ISession session = SessionManager.GetSession();


            if (session == null)
                return;
            List<ProfesorPredmetOdeljenje> profesori = DataProvider.VratiPredmetOdeljenjeZaProfesora(profesorID);

            foreach (ProfesorPredmetOdeljenje ppo in profesori)
            {

                RowSet ocData = session.Execute("delete from \"ProfesorPredmetOdeljenje\" where \"profesorid\" = '" + ppo.profesorID + "' and \"predmetid\" = '" + ppo.predmetID + "' and \"odeljenjeid\" = '" + ppo.odeljenjeId +"'");
            }
        }

        public static List<ProfesorPredmetOdeljenje> VratiPredmetOdeljenjeZaProfesora(string profesorID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            List<ProfesorPredmetOdeljenje> profesori = new List<ProfesorPredmetOdeljenje>();
            var ppoData = session.Execute("select * from \"ProfesorPredmetOdeljenje\" where \"profesorid\"='" + profesorID + "' allow filtering");


            foreach (var ppo in ppoData)
            {
                ProfesorPredmetOdeljenje prof = new ProfesorPredmetOdeljenje();
                prof.profesorID = ppo["profesorid"] != null ? ppo["profesorid"].ToString() : string.Empty;
                prof.predmetID = ppo["predmetid"] != null ? ppo["predmetid"].ToString() : string.Empty;
                prof.imeProfesor = ppo["imeprofesor"] != null ? ppo["imeprofesor"].ToString() : string.Empty;
                prof.prezimeProfesor = ppo["prezimeprofesor"] != null ? ppo["prezimeprofesor"].ToString() : string.Empty;
                prof.odeljenjeId = ppo["odeljenjeid"] != null ? ppo["odeljenjeid"].ToString() : string.Empty;
                prof.nazivPredmeta = ppo["nazivpredmeta"] != null ? ppo["nazivpredmeta"].ToString() : string.Empty;
                

                profesori.Add(prof);
            }



            return profesori;
        }

        
        #endregion
    }



}



