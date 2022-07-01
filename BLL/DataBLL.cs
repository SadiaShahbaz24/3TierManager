using AppProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DataBLL
    {
        DataDAL dDAL = new DataDAL();

        //functions for student
        public bool StuInsertBLL(StuData sdata)
        {
            return dDAL.StuInsertDAL(sdata);
        }
        public bool StuUpdateBLL(StuData sdata)
        {
            return dDAL.StuUpdateDAL(sdata);
        }
        public bool StuDeleteBLL(StuData sdata)
        {
            return dDAL.StuDeleteDAL(sdata);
        }
        public DataTable StuSearchBLL(StuData sdata)
        {
            return dDAL.StuSearchDAL(sdata);
        }
        public DataTable StuGetAllBLL()
        {
            return dDAL.StuGetAllDAL();
        }


        //functions for teacher
        public bool TeaInsertBLL(TeaData tdata)
        {
            return dDAL.TeaInsertDAL(tdata);
        }
        public bool TeaUpdateBLL(TeaData tdata)
        {
            return dDAL.TeaUpdateDAL(tdata);
        }
        public bool TeaDeleteBLL(TeaData tdata)
        {
            return dDAL.TeaDeleteDAL(tdata);
        }
        public DataTable TeaSearchBLL(TeaData tdata)
        {
            return dDAL.TeaSearchDAL(tdata);
        }
        public DataTable TeaGetAllBLL()
        {
            return dDAL.TeaGetAllDAL();
        }

        //function of course
        public bool CouInsertBLL(CouData cdata)
        {
            return dDAL.CouInsertDAL(cdata);
        }
        public bool CouUpdateBLL(CouData cdata)
        {
            return dDAL.CouUpdateDAL(cdata);
        }
        public bool CouDeleteBLL(CouData cdata)
        {
            return dDAL.CouDeleteDAL(cdata);
        }
        public DataTable CouSearchBLL(CouData cdata)
        {
            return dDAL.CouSearchDAL(cdata);
        }
        public DataTable CouGetAllBLL()
        {
            return dDAL.CouGetAllDAL();
        }
    }
}
