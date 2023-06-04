namespace Models.EntityBase
{
    public class EntityBase
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        /* * * * * * * * * * * * * * * * * *\
        |*             ABSTRACT            *|
        \* * * * * * * * * * * * * * * * * */

        public virtual int IdentityId()
        {
            return 0;
        }

        public virtual object[] IdentityId(bool dummy = true)
        {
            return new List<object>().ToArray();
        }
    }
}
