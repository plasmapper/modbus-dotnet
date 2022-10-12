# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.1.0] - 2022-10-12
### Added
- ConnectTimeout property.

### Changed
- Disabled Nagle's algorithm.

## [2.0.1] - 2022-10-11
### Added
- ExceptionCode enum.
- DelayAfterRead property.

### Changed
- FunctionCode enum naming.
- Timeout property to ReadTimeout property.

### Fixed
- ReadTimeout setting in examples.