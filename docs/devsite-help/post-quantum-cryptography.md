# Post-quantum cryptography (PQC) support

To protect against the "Store Now, Decrypt Later" threat, Google Cloud is implementing Post-Quantum Cryptography (PQC) across its services. For more information on Google Cloud's approach, see [Post-Quantum Cryptography on Google Cloud](https://cloud.google.com/security/resources/post-quantum-cryptography).

## Post-quantum key exchange

To support post-quantum key exchange, Google Cloud client libraries support post-quantum and hybrid key exchange mechanisms (such as standardized ML-KEM combined with classical algorithms) for TLS 1.3 connections.

## .NET SDK support

No additional configuration or code changes are required when using Google Cloud .NET client libraries. The underlying TLS engine delegates TLS 1.3 handshakes to the host operating system and automatically negotiates post-quantum key exchange (such as standardized ML-KEM hybrid groups) when running on a supported platform.

To verify whether your host environment has post-quantum groups registered (look for `MLKEM` in the output):

* **Linux**: Uses the system-installed OpenSSL library (requires OpenSSL 3.5.0 or later, or a configured PQC provider):
  ```bash
  openssl list -tls-groups
  ```
* **Windows**: Requires build 26100 or later:
  ```powershell
  Get-TlsEccCurve
  ```
* **macOS**: Uses Apple's Network framework (requires macOS 26 or later).

If connecting through a network proxy or to an endpoint that does not support PQC, the TLS handshake automatically falls back to classical key exchange algorithms.
