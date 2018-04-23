namespace RoseBloom.Data.Common
{
    public class UpdateEntityResult<T>
    {
        public bool Result { get; set; }
        public T Entity { get; set; }
        public string Message { get; set; }

    }
}
