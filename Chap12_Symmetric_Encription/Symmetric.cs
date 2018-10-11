using System.Security.Cryptography;

namespace Chap12_Symmetric_Encription
{
    public class Symmetric
    {
        public byte[] EncryptData(byte[] plainData, byte[] IV, byte[] key)
        {
            // Create a symmetric algorithm by call Create
            SymmetricAlgorithm cryptoAlgorithm = SymmetricAlgorithm.Create();
            
            // Create encryptor object by calling CreateEncryptor method
            ICryptoTransform encryptor = cryptoAlgorithm.CreateEncryptor(key, IV);

            // Call the TransformFinalBlock to return the encrypted data back
            byte[] cipherData = encryptor.TransformFinalBlock(plainData, 0, plainData.Length);

            return cipherData;
        }


        public byte[] DecryptData(byte[] cipherData, byte[] IV, byte[] key)
        {
            // Create symmetric algorithm object by calling Create
            SymmetricAlgorithm cryptoAlgorithm = SymmetricAlgorithm.Create();

            // Create a decryptor object by calling CreateDycrptor
            ICryptoTransform decryptor = cryptoAlgorithm.CreateDecryptor(key, IV);

            // Call the TransformFinalBlock to return the plain data 
            byte[] plainData = decryptor.TransformFinalBlock(cipherData, 0, cipherData.Length);

            return plainData;
        }
    }
}