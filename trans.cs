System.Data.IDbTransaction tran = MySql.SqlConnection.BeginTransaction();
// MySql est un objet de ma class SgBd.

try
{
  // On fait le suite de requète.
  
  
  // si tout se passe bien.
  tran.Commit();
}
catch
{
  // si tout ne se passe pas bien
  tran.Rollback();
}
